using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Web.Mvc;
using MilwaukeeBeerCraft;
using System.Runtime.Remoting;
using MilwaukeeBeerCraft.Models;
using MilwaukeeBeerCraft.Backend;

namespace MilwaukeeBeerCraft
{
    public class Untapped
    {
        string clientId = "725FB5BFDB5667974755E4B3FD8EB190D1484975";
        string clientSecret = "245966DD86209D2B4EE379E9E51D24B4ABC687E1";
        
        ApplicationDbContext context = new ApplicationDbContext();
        
        public string Get(int id)
        {

            return "value";
        }

      
        
        public List<VenueNameId> BrewerySearch()
        {
            LinqDeserialize linq = new LinqDeserialize();
            List<string> breweries = new List<string>();
            List<VenueNameId> venues = new List<VenueNameId>();
            UTF8Encoding enc = new UTF8Encoding();

            //data
            string data = "";

            //Create request
            WebRequest request = WebRequest.Create("https://api.untappd.com/v4/search/brewery/q=Milwaukee?client_id=725FB5BFDB5667974755E4B3FD8EB190D1484975&client_secret=245966DD86209D2B4EE379E9E51D24B4ABC687E1");

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Credentials = new NetworkCredential("725FB5BFDB5667974755E4B3FD8EB190D1484975", "245966DD86209D2B4EE379E9E51D24B4ABC687E1");

            //Set data in request
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(enc.GetBytes(data), 0, data.Length);


            //Get the response
            WebResponse wr = request.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string breweryBack = reader.ReadToEnd();
            breweries.Add(breweryBack);

            // Convert the Response
            venues = linq.ReadBreweryFoursquareCall(breweries);
            
            return (venues);
        }

        public List<BeerListObject> CallUntappedBreweryByBreweryId(List<UntappedBrewery> breweries)
        {
            LinqDeserialize linq = new LinqDeserialize();
            List<string> beersInfo = new List<string>();
            List<BeerListObject> beersList = new List<BeerListObject>();
            List<List<BeerListObject>> ListOfLists = new List<List<BeerListObject>>();

            foreach (var b in breweries)
            {
                //encoder
                UTF8Encoding enc = new UTF8Encoding();

                //data
                string data = "";

                //Create request
                WebRequest request = WebRequest.Create("https://api.untappd.com/v4/brewery/beer_list/" + b.untappedBid + "?client_id=725FB5BFDB5667974755E4B3FD8EB190D1484975&client_secret=245966DD86209D2B4EE379E9E51D24B4ABC687E1");

                request.Method = "POST";
                request.ContentType = "application/json";
                request.Credentials = new NetworkCredential("725FB5BFDB5667974755E4B3FD8EB190D1484975", "245966DD86209D2B4EE379E9E51D24B4ABC687E1");

                //Set data in request
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(enc.GetBytes(data), 0, data.Length);


                //Get the response
                WebResponse wr = request.GetResponse();
                Stream receiveStream = wr.GetResponseStream();
                StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
                string beersBack = reader.ReadToEnd();
                beersInfo.Add(beersBack);
                
            }
            // Convert the Response
            beersList = linq.ReadBreweryListCall(beersInfo);

            SaveTheBeersList(beersList);
            return (beersList);
        }

        private void SaveTheBeersList(List<BeerListObject> beersList)
        {
            context.BeerListObject.AddRange(beersList);
            context.SaveChanges();

        }

        public List<string> GetBeersByStyle()
        {
            var distinctStyles = context.Beer.Select(s => s.beer_style).Distinct().ToList();
            return distinctStyles;
        }
        //public string GetStyleChoice()
        //{
        //    string styleChoice = 
        //    return styleChoice;
        //}
    }
}
