using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if ( await userManager.Users.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("../Infrastructure/Data/SeedData/UserSeedData.json");
            var users= JsonSerializer.Deserialize<List<AppUser>>(userData);
            if (users == null) return;

            foreach (var user in users)
            {
                user.DisplayName = user.DisplayName.ToLower();
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }

        }
             
    }
        
    }
