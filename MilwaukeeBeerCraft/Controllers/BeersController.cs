﻿using System;
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
        private ApplicationDbContext db = new ApplicationDbContext();
        Untapped untapped = new Untapped();

        // GET: Breweries
        public ActionResult Index()
        {
            var beer = new ApplicationDbContext().Beer;
            
            BeersByStyleViewModel beersByStyle = new BeersByStyleViewModel();
            
            ViewBag.Message = "Beers page.";
            //var beerListsByBrewery = new ApplicationDbContext().Beer.ToList();
            return View(beersByStyle);
        }
        
        public JsonResult UpdateStylesList(string beer_style)
        {
            List<BeersByStyleViewModel> listOfBeersByStyle = new List<BeersByStyleViewModel>();
            
            var beersInStyle = db.Beer.Where(s => s.beer_style == beer_style);

            foreach (var beer in beersInStyle)
            {
                BeersByStyleViewModel beerToAdd = new BeersByStyleViewModel();
                {
                    beerToAdd.name = beer.beer_name;
                    beerToAdd.abv = beer.beer_abv;
                    beerToAdd.ibu = beer.beer_ibu;
                    beerToAdd.slug = beer.beer_slug;
                    beerToAdd.rating = beer.rating_score;
                    beerToAdd.style = beer.beer_style;

                    listOfBeersByStyle.Add(beerToAdd);
                }
            }

            return Json(listOfBeersByStyle.ToList(), JsonRequestBehavior.AllowGet);
        }

        public List<string> GetBreweries()
        {
            var distinctBreweries = db.Brewery.Select(s => s.brewery_name).Distinct().ToList();
            return distinctBreweries;
        }

        public ActionResult StyleSelector()
        {
            Untapped untapped = new Untapped();
            List<string> stylesList = untapped.GetBeersByStyle();

            return View(stylesList);
        }

        public ActionResult BeerGraphs()
        {
            Untapped untapped = new Untapped();
            List<string> stylesList = untapped.GetBeersByStyle();

            return View(stylesList);
        }

       
    }
}
