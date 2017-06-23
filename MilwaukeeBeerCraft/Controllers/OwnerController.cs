using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using MilwaukeeBeerCraft.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MilwaukeeBeerCraft.Controllers
{
    public class OwnerController : Controller
    {
        
        ApplicationDbContext context = new ApplicationDbContext();
        private ApplicationUserManager _userManager;
        // GET: Owner
        public ActionResult Index()
        {
            return View();
        }
        //public  ActionResult AdminUsers()
        //{
        //    List<AdminUsersRoleModel> AdminUsers = new List<AdminUsersRoleModel>();
        //    var users = new ApplicationDbContext().Users.ToList();
        //    foreach (var user in users)
        //    {
        //        AdminUsers.Add(new AdminUsersRoleModel() { UserName = user.UserName, Role = UserManager.GetRoles(user.Id).Count > 0 ? UserManager.GetRoles(user.Id).Aggregate((a, b) => a + "/" + b) : "None" });
        //    }
        //    return View(new ApplicationDbContext().Users.ToList());
        //}

      
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value; 
            }
        }
    }
}