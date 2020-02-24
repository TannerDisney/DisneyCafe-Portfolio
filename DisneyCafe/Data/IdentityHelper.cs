using DisneyCafe.Models.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCafe.Data
{
    public static class IdentityHelper
    {
        internal static readonly string Owner = "Owner";
        internal static readonly string Administrator = "Administrator";

        internal static async Task CreateRoles(IServiceProvider provider, params string[] roles)
        {
            RoleManager<IdentityRole> roleManager =
                provider.GetRequiredService<RoleManager<IdentityRole>>();
            IdentityResult roleResult;

            foreach (string role in roles)
            {
                bool doesRoleExist = await roleManager.RoleExistsAsync(role);
                if (!doesRoleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        internal static async Task SeedRoles(IServiceProvider provider, string adminrole, string ownerrole)
        {
            // Administrator Credentials
            string administratorEmail = "disneycafeadmin@disneycafe.online";
            string administratorPassword = "Cptc@2020";

            // Owner Credentials
            string ownerEmail = "disneycafeowner@disneycafe.online";
            string ownerPassword = "Cptc@2020";

            var userManager = provider.GetRequiredService<UserManager<IdentityUser>>();

            // If no users are in the database, create admin and owner accounts
            if (userManager.Users.Count() == 0)
            {
                // Create Admin User
                IdentityUser adminUser = new IdentityUser()
                {
                    Email = administratorEmail,
                    UserName = administratorEmail
                };

                // Create Owner User
                IdentityUser ownerUser = new IdentityUser()
                {
                    Email = ownerEmail,
                    UserName = ownerEmail
                };

                // Create and Add Admin account
                await userManager.CreateAsync(adminUser, administratorPassword);
                await userManager.AddToRoleAsync(adminUser, adminrole);

                await userManager.CreateAsync(ownerUser, ownerPassword);
                await userManager.AddToRoleAsync(ownerUser, ownerrole);
            }
        }

        internal static void SetIdentityConfigOptions(IdentityOptions options)
        {
            options.Password.RequireDigit = false;
            options.Password.RequiredLength = 8;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireNonAlphanumeric = false;
        }
    }
}
