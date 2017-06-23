using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class Post
    {
        public virtual int Id
        { get; set; }
        public virtual string Title
        { get; set; }
        public virtual string Description
        { get; set; }
        public virtual bool Published
        { get; set; }
        public virtual DateTime PostedOn
        { get; set; }
        public virtual DateTime? Modified
        { get; set; }
        public virtual Category Category
        { get; set; }
        public virtual string UrlSlug
        { get; set; }
        public virtual ICollection<Brewery> Brewery
        { get; set; }
        public virtual ICollection<Beers> Beers
        { get; set; }

    }
}