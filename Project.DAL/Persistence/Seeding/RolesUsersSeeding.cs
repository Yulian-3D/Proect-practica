using Microsoft.AspNetCore.Identity;
using Project.DAL.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace JWTWithCookiesAndRefreshTokens.Data.Seeding
{
    public class RolesUsersSeeding
    {
        public static async Task SeedRolesAsync(RoleManager<UserRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(
                    new UserRole { Id = 1, Name = "Administrator", NormalizedName = "ADMINISTRATOR".ToUpper() });
            }

            if (!await roleManager.RoleExistsAsync("User"))
            {
                await roleManager.CreateAsync(
                    new UserRole { Id = 2, Name = "User", NormalizedName = "USER".ToUpper() });
            }
        }

        public static async Task SeedUsersAsync(UserManager<User> userManager)
        {
            // Seed Admin User
            var adminUser = new User
            {
                Id = 1,
                UserName = "adminUser@example.com",
                Email = "adminUser@example.com",
                NormalizedUserName = "ADMINUSER",
                Name = "Admin User",
                Count = 1000
            };

            if (userManager.Users.All(u => u.UserName != adminUser.UserName))
            {
                var result = await userManager.CreateAsync(adminUser, "Admin123!");
                if (result.Succeeded)
                {
                    // Assign the "Admin" role to the admin user
                    await userManager.AddToRoleAsync(adminUser, "Administrator");
                }
            }

            // Seed Standard User
            var standardUser = new User
            {
                Id = 2,
                UserName = "user@example.com",
                Email = "user@example.com",
                NormalizedUserName = "USER",
                Name = "Standard User",
                Count = 100
            };

            if (userManager.Users.All(u => u.UserName != standardUser.UserName))
            {
                var result = await userManager.CreateAsync(standardUser, "User123!");
                if (result.Succeeded)
                {
                    // Assign the "User" role to the standard user
                    await userManager.AddToRoleAsync(standardUser, "User");
                }
            }
        }
    }
}
