using MilwaukeeBeerCraft.Models;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft
{
    public class BlogRepository
    {
        private readonly ISession _session;

        public BlogRepository(ISession session)
        {
            _session = session;
        }

        public IList<Post> Posts(int pageNo, int pageSize)
        {
            var posts = _session.Query<Post>()
                                  .Where(p => p.Published)
                                  .OrderByDescending(p => p.PostedOn)
                                  .Skip(pageNo * pageSize)
                                  .Take(pageSize)
                                  .Fetch(p => p.Category)
                                  .ToList();

            var postIds = posts.Select(p => p.Id).ToList();

            return _session.Query<Post>()
                  .Where(p => postIds.Contains(p.Id))
                  .OrderByDescending(p => p.PostedOn)
                  .FetchMany(p => p.Beer)
                  .ToList();
        }

        public int TotalPosts()
        {
            return _session.Query<Post>().Where(p => p.Published).Count();
        }
        public IList<Post> PostsForCategory(string categorySlug, int pageNo, int pageSize)
        {
            var posts = _session.Query<Post>()
                                .Where(p => p.Published && p.Category.Equals(categorySlug))
                                .OrderByDescending(p => p.PostedOn)
                                .Skip(pageNo * pageSize)
                                .Take(pageSize)
                                .Fetch(p => p.Category)
                                .ToList();

            var postIds = posts.Select(p => p.Id).ToList();

            return _session.Query<Post>()
                          .Where(p => postIds.Contains(p.Id))
                          .OrderByDescending(p => p.PostedOn)
                          .FetchMany(p => p.Brewery)
                          .ToList();
        }

        public int TotalPostsForCategory(string categorySlug)
        {
            return _session.Query<Post>()
                        .Where(p => p.Published && p.Category.Equals(categorySlug))
                        .Count();
        }

        public Category Category(string categorySlug)
        {
            return _session.Query<Category>()
                        .FirstOrDefault(t => t.UrlSlug.Equals(categorySlug));
        }
        public IList<Category> Categories()
        {
            return _session.Query<Category>().OrderBy(p => p.Name).ToList();
        }
        public IList<BeerStyles> Beers()
        {
            return _session.Query<BeerStyles>().OrderBy(p => p.Name).ToList();
        }

        public IList<MilwaukeeBreweries> Breweries()
        {
            return _session.Query<MilwaukeeBreweries>().OrderBy(p => p.Name).ToList();
        }

        //public IList<Post> PostsForBeer()
        //{
        //    var posts =_session.Query<Post>()

        //}

        //public IList<Post> PostsForTag(string tagSlug, int pageNo, int pageSize)
        //{
        //    var posts = _session.Query<Post>()
        //                      .Where(p => p.Published && p.Tags.Any(t => t.UrlSlug.Equals(tagSlug)))
        //                      .OrderByDescending(p => p.PostedOn)
        //                      .Skip(pageNo * pageSize)
        //                      .Take(pageSize)
        //                      .Fetch(p => p.Category)
        //                      .ToList();

        //    var postIds = posts.Select(p => p.Id).ToList();

        //    return _session.Query<Post>()
        //                  .Where(p => postIds.Contains(p.Id))
        //                  .OrderByDescending(p => p.PostedOn)
        //                  .FetchMany(p => p.Tags)
        //                  .ToList();
        //}

        //public int TotalPostsForTag(string tagSlug)
        //{
        //    return _session.Query<Post>()
        //                .Where(p => p.Published && p.Tags.Any(t => t.UrlSlug.Equals(tagSlug)))
        //                .Count();
        //}

        //public Tag Tag(string tagSlug)
        //{
        //    return _session.Query<Tag>()
        //                .FirstOrDefault(t => t.UrlSlug.Equals(tagSlug));
        //}
    }
}