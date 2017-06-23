using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MilwaukeeBeerCraft
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // starts top & if no routes found gives 404

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Category",
                "Category/{category}",
                 new { controller = "Blog", action = "Category" }
            );

            // Default controller 
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            ); 
        }
    }
}
