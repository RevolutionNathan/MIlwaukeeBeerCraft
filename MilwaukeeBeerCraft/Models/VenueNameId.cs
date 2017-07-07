using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class VenueNameId
    {
        public int venue_id { get; internal set; }
        public string venue_name { get; internal set; }
        [Key]
        public int id { get;  internal set;}
    }
}