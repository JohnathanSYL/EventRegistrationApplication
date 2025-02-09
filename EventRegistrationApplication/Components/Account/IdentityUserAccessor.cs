using EventRegistrationApplication.Data;
using EventRegistrationApplication.Domain;
using Microsoft.AspNetCore.Identity;

namespace EventRegistrationApplication.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<EventRegistrationApplicationUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<EventRegistrationApplicationUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
