using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class Post
    {
        public  int Id { get; set; }
        public  string Title{ get; set; }
        public  bool Published { get; set; }
        public  DateTime PostedOn { get; set; }
        public  DateTime? Modified { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        public string Brewery { get; set; }
        public string Beer { get; set; }

    }
}