using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class BreweryObject
    {
        public class ResponseTime
        {
            public double time { get; set; }
            public string measure { get; set; }
        }

        public class InitTime
        {
            [Key]
            public int id { get; set; }
            public double time { get; set; }
            public string measure { get; set; }
            
        }

        public class Meta
        {
            public int code { get; set; }
            public ResponseTime response_time { get; set; }
            public InitTime init_time { get; set; }
        }

        public class Item
        {
            public string venue_name { get; set; }
            public int venue_id { get; set; }
            public string foursquare_id { get; set; }
            public string last_updated { get; set; }
        }

        public class Venue
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }

        public class Response
        {
            public Venue venue { get; set; }
        }

        public class BreweriesReturnedObject
        {
            public Meta meta { get; set; }
            public List<object> notifications { get; set; }
            public Response response { get; set; }
        }
    }
}