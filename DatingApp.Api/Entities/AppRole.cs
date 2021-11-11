﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DatingApp.Api.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
