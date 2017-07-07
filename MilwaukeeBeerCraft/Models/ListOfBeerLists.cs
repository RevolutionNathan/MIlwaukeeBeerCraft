using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class ListOfBeerLists
    {
        public List<BeerListObject> BeerLists
        { get; set; }

        [Key]
        public int ListId
        { get; set; }
        
    }
}

