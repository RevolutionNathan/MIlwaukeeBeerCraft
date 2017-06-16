using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using MilwaukeeBeerCraft.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(MilwaukeeBeerCraft.Startup))]
namespace MilwaukeeBeerCraft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateAdmin();
        }

        public void CreateAdmin()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Owner"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Owner";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.UserName = "nathan@milwaukeebeercraft.com";
                user.Email = "nathan@milwaukeebeercraft.com";
                string userPWD = "B.e.e.r.1981";
                var chkUser = UserManager.Create(user, userPWD);

                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Owner");
                }
            }

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

            }

        }
    }
}
