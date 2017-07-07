using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using MilwaukeeBeerCraft.Models;
using static MilwaukeeBeerCraft.Models.BreweryObject;

namespace MilwaukeeBeerCraft.Backend
{
    public class LinqDeserialize
    {
        public List<VenueNameId> ReadBreweryFoursquareCall(List<string> breweries)
        {
            List<VenueNameId> VenueIdNames = new List<VenueNameId>();
            foreach (var brewery in breweries)
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                BreweriesReturnedObject untappdBreweries = serializer.Deserialize<BreweriesReturnedObject>(brewery);
                

                VenueNameId Venue = new VenueNameId();
                {
                    Venue.venue_id = untappdBreweries.response.venue.items[0].venue_id;
                    Venue.venue_name = untappdBreweries.response.venue.items[0].venue_name;
                    VenueIdNames.Add(Venue);
                }
            }
            return VenueIdNames;
        }

        internal List<UntappedBrewery> ReadBreweryByVenueCall(List<string> breweries)
        {
            List<UntappedBrewery> VenueInfo = new List<UntappedBrewery>();
            foreach (var brewery in breweries)
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                VenueRootObject untappdBreweries = serializer.Deserialize<VenueRootObject>(brewery);
                
                UntappedBrewery Brewery = new UntappedBrewery();
                {
                    Brewery.untappedBid = untappdBreweries.venue.media.items.brewery.brewery_id;
                    Brewery.breweryName = untappdBreweries.venue.venue_name;
                    VenueInfo.Add(Brewery);
                }
            }
            return VenueInfo;
        }

        internal List<BeerListObject> ReadBreweryListCall(List<string> beers)
        {
            List<BeerListObject> beerList = new List<BeerListObject>();
            foreach (var beer in beers)
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                BeerListObject individualbeer = serializer.Deserialize<BeerListObject>(beer);
                beerList.Add(individualbeer);
            }
            return beerList;
        }

        //internal List<Models.Response> ReadBeerLists(List<string> beers)
        //{
        //    List<Models.Response> BeerLists = new List<Models.Response>();
        //    foreach 
        //}
    }

    

}