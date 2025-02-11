using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using EventRegistrationApplication.Data;
using EventRegistrationApplication.Domain;
using EventRegistrationApplication.Components.Account;

public partial class Register
{
    [Inject] private UserManager<EventRegistrationApplicationUser> UserManager { get; set; } = default!;
    [Inject] private IUserStore<EventRegistrationApplicationUser> UserStore { get; set; } = default!;
    [Inject] private SignInManager<EventRegistrationApplicationUser> SignInManager { get; set; } = default!;
    [Inject] private IEmailSender<EventRegistrationApplicationUser> EmailSender { get; set; } = default!;
    [Inject] private ILogger<Register> Logger { get; set; } = default!;
    [Inject] private NavigationManager NavigationManager { get; set; } = default!;
    [Inject] private IdentityRedirectManager RedirectManager { get; set; } = default!;
    [Inject] private RoleManager<IdentityRole> RoleManager { get; set; } = default!;

    private IEnumerable<IdentityError>? identityErrors;
    private string? Message => identityErrors is null ? null : $"Error: {string.Join(", ", identityErrors.Select(error => error.Description))}";

    [SupplyParameterFromForm] private InputModel Input { get; set; } = new();
    [SupplyParameterFromQuery] private string? ReturnUrl { get; set; }

    private async Task RegisterUser(EditContext editContext)
    {
        var user = CreateUser();
        await UserStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
        var emailStore = GetEmailStore();
        await emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);

        user.FirstName = Input.FirstName;
        user.LastName = Input.LastName;

        var result = await UserManager.CreateAsync(user, Input.Password);

        if (!result.Succeeded)
        {
            identityErrors = result.Errors;
            return;
        }

        if (!await RoleManager.RoleExistsAsync("User"))
        {
            await RoleManager.CreateAsync(new IdentityRole("User"));
        }

        await UserManager.AddToRoleAsync(user, "User");
        await UserManager.AddClaimAsync(user, new System.Security.Claims.Claim("userId", user.Id));

        Logger.LogInformation("User created a new account with password.");

        var userId = await UserManager.GetUserIdAsync(user);
        var code = await UserManager.GenerateEmailConfirmationTokenAsync(user);
        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        var callbackUrl = NavigationManager.GetUriWithQueryParameters(
            NavigationManager.ToAbsoluteUri("Account/ConfirmEmail").AbsoluteUri,
            new Dictionary<string, object?> { ["userId"] = userId, ["code"] = code, ["returnUrl"] = ReturnUrl });

        await EmailSender.SendConfirmationLinkAsync(user, Input.Email, HtmlEncoder.Default.Encode(callbackUrl));

        if (UserManager.Options.SignIn.RequireConfirmedAccount)
        {
            RedirectManager.RedirectTo("Account/RegisterConfirmation", new() { ["email"] = Input.Email, ["returnUrl"] = ReturnUrl });
        }

        await SignInManager.SignInAsync(user, isPersistent: false);
        RedirectManager.RedirectTo(ReturnUrl);
    }

    private EventRegistrationApplicationUser CreateUser()
    {
        try
        {
            return Activator.CreateInstance<EventRegistrationApplicationUser>()!;
        }
        catch
        {
            throw new InvalidOperationException($"Can't create an instance of '{nameof(EventRegistrationApplicationUser)}'. " +
                $"Ensure that '{nameof(EventRegistrationApplicationUser)}' is not an abstract class and has a parameterless constructor.");
        }
    }

    private IUserEmailStore<EventRegistrationApplicationUser> GetEmailStore()
    {
        if (!UserManager.SupportsUserEmail)
        {
            throw new NotSupportedException("The default UI requires a user store with email support.");
        }
        return (IUserEmailStore<EventRegistrationApplicationUser>)UserStore;
    }

    private sealed class InputModel
    {
        [Required, EmailAddress, Display(Name = "Email")]
        public string Email { get; set; } = "";

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; } = "";

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; } = "";

        [Required, StringLength(100, MinimumLength = 6, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = "";

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = "";
    }
}
