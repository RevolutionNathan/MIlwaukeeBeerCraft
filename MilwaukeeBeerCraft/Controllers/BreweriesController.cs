using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using MilwaukeeBeerCraft.Models;
using MilwaukeeBeerCraft;

namespace MilwaukeeBeerCraft.Controllers
{
    public class BreweriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        Untapped untapped = new Untapped();
        
        // GET: Breweries
        public ActionResult Index()
        {
            ViewBag.Message = "Your Breweries page.";
            var breweries = new ApplicationDbContext().MilwaukeeBreweries.ToList();

            return View(breweries);
        }

        //var breweries = new ApplicationDbContext().UntappedBrewery.ToList();
        ////List<VenueNameId> venues = untapped.CallUntappedBreweryFourSquare(breweries);
        ///*List<List<UnTappedBeer>> beerLists = */
        //var listOfBeerLists = untapped.CallUntappedBreweryByBreweryId(breweries);

    }
}
