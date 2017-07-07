using System.Collections.Generic;

namespace MilwaukeeBeerCraft.Models
{
    public class MilwaukeeBreweries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public ICollection<Post> Posts { get; set; }


    }
}