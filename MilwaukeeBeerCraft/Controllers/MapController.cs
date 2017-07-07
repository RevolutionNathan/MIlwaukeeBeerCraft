using MilwaukeeBeerCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilwaukeeBeerCraft.Controllers
{
    public class MapController : Controller
    {
        public ActionResult MapView()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var breweries = db.MilwaukeeBreweries.ToList();

            return View(breweries);
        }
    }
}