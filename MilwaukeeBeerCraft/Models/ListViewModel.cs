using MilwaukeeBeerCraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class ListViewModel
    {
        public ListViewModel(BlogRepository blogRepository, int p)
        {
            Posts = blogRepository.Posts(p - 1, 10);
            TotalPosts = blogRepository.TotalPosts();
        }

        public ListViewModel(BlogRepository blogRepository, string categorySlug, int p)
        {
            Posts = blogRepository.PostsForCategory(categorySlug, p - 1, 10);
            TotalPosts = blogRepository.TotalPostsForCategory(categorySlug);
            Category = blogRepository.Category(categorySlug);
        }

        //Posts by beer type can I use a simple linq expression to find where beer.stylename = true ?
       
        public IList<Post> Posts { get; set; }
        public int TotalPosts { get; set; }
        public Category Category { get; private set; }
        public Beers Beers { get; private set; }

    }
}