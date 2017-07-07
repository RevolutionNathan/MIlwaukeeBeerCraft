using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class UntappedBrewery
    {
        [Key]
        public int bid
        { get; set; }
        public string breweryName
        { get; set; }
        public int untappedBid
        { get; set; }
        public string breweryInfo
        { get; set; }
        //public BreweryLocation location { get; set; }
    }

    //public class BreweryLocation
    //{
    //    public string venue_address { get; set; }
    //    public string venue_city { get; set; }
    //    public string venue_state { get; set; }
    //    public string venue_country { get; set; }
    //    public double lat { get; set; }
    //    public double lng { get; set; }
    //}
    
}