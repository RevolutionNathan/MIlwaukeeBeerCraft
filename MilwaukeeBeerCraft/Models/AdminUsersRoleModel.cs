using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class AdminUsersRoleModel
    {
        public string Role { get; set;}
        public IEnumerable<string> RoleNames { get; set; }
        public string UserName { get; set; }
        public string Email {get; set;}
    }
}