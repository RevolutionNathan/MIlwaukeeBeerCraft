using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using MilwaukeeBeerCraft.Models;

namespace MilwaukeeBeerCraft.Controllers
{
    public class BeersController : Controller
    {
       public ActionResult Index()
        {
            ViewBag.Message = "Your Beers page.";

            return View();
        }


    }
}
