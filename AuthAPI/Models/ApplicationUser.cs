﻿using Microsoft.AspNetCore.Identity;

namespace AuthAPI.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName {  get; set; }
        public int Age {  get; set; }

    }
}
