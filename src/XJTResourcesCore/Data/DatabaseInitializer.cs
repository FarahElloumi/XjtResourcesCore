using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using XJTResourcesCore.Models;

namespace XJTResourcesCore.Data
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
       
        public DatabaseInitializer(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;

        }


        public async Task Seed()
        {
            await _context.Database.MigrateAsync();

            if (_context.Applications.Any())
            {
                await _context.Applications.ForEachAsync(c => {

                    _context.Entry(c).State = EntityState.Deleted;

                });

                await _context.SaveChangesAsync();
            }


            //using (var database = app.ApplicationServices.GetService<ApplicationDbContext>())
            //{
            //    database.Applications.Add(new Application
            //    {
            //        Id = "XJTResourcesClient",
            //        DisplayName = "XJTResources",
            //        RedirectUri = "http://locahost:5000/signin-oidc",
            //        LogoutRedirectUri = "http://localhost:5000",
            //        Secret = "Super_Dooper_Secret"
            //    });

            //    database.SaveChanges();
            //}

            var email = "mvermef@gmail.com";

            ApplicationUser user;
            if( (user = await _userManager.FindByNameAsync(email)) == null)
            {
                //createw another user...
            }


                


            var roleName = "Admin";
            if (await _roleManager.FindByNameAsync(roleName) == null)
                await _roleManager.CreateAsync(new ApplicationRole() { Name = roleName });

            if(!await _userManager.IsInRoleAsync(user, roleName))
            {
                await _userManager.AddToRoleAsync(user, roleName);
                
            }
        }

    }

    public interface IDatabaseInitializer
    {
        Task Seed();
    }
}
