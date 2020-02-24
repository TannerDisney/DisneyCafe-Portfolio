using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCafe.Models.Database
{
    /// <summary>
    /// ApplicationUser inherits from IdentityUser to have access to the
    /// user table
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Gets all roles associated from the user
        /// </summary>
        public List<IdentityRole> Roles { get; set; }
        /// <summary>
        /// If the user belongs to the Administrator role 
        /// this will be true
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}
