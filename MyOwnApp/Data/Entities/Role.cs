﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Entities
{
    public class Role:IdentityRole<string>
    {
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}
