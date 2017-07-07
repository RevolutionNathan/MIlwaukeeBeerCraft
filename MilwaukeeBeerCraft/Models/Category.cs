using System.Collections.Generic;

namespace MilwaukeeBeerCraft.Models
{
    public class Category
    {
        public virtual int Id
        { get; set; }
        public virtual string Name
        { get; set; }
        public virtual string UrlSlug
        { get; set; }
        public virtual string Beer
        { get; set; }
        public virtual string Brewery
        { get; set; }
        public virtual string Event
        { get; set; }
        public virtual string People
        { get; set; }
        public virtual ICollection<Post> Posts
        { get; set; }
    }
}