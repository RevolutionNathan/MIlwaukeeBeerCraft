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
        public virtual bool Beer
        { get; set; }
        public virtual bool Brewery
        { get; set; }
        public virtual bool Event
        { get; set; }
        public virtual bool People
        { get; set; }
        public virtual ICollection<Post> Posts
        { get; set; }
    }
}