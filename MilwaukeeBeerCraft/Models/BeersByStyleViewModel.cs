using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class BeersByStyleViewModel
    {
        public string styleChoice { get; set; }
        public double rating { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public double abv { get; set; }
        public double ibu { get; set; }
        public string style { get; set; }
    }
}