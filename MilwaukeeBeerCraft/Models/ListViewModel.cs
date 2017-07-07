using MilwaukeeBeerCraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class ListViewModel
    {
        public IList<Post> Posts { get; set; }
        public int TotalPosts { get; set; }
        public IList<string> category { get;  set; }
        public IList<string> beerStyles { get;  set; }
        public IList<string> breweries {get; set;}
        public string Content { get; set; }
        public string Title { get; set; }


    }
}