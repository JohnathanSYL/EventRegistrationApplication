﻿using Microsoft.AspNetCore.Identity;

namespace EventRegistrationApplication.Domain
{
    public class EventRegistrationApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
