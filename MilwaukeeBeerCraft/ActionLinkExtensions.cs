using MilwaukeeBeerCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MilwaukeeBeerCraft
{
    public static class ActionLinkExtensions
    {
        public static MvcHtmlString PostLink(this HtmlHelper helper, Post post)
        {
            return helper.ActionLink(post.Title, "Post", "Blog",
                new
                {
                    year = post.PostedOn.Year,
                    month = post.PostedOn.Month,
                    title = post.Title
                },
                new
                {
                    title = post.Title
                });
        }

        public static MvcHtmlString CategoryLink(this HtmlHelper helper,
            Category category)
        {
            return helper.ActionLink(category.Name, "Category", "Blog",
                new
                {
                    category = category.UrlSlug
                },
                new
                {
                    title = String.Format("See all posts in {0}", category.UrlSlug)
                });
        }

        public static MvcHtmlString BeerLink(this HtmlHelper helper, Beers beers)
        {
            return helper.ActionLink(beers.Name, "Beer", "Blog", new { beers = beers },
                new
                {
                    title = String.Format("See all posts in {0}", beers.UrlSlug)
                });
        }
        public static MvcHtmlString BreweryLink(this HtmlHelper helper, Brewery brewery)
        {
            return helper.ActionLink(brewery.Name, "Brewery", "Blog", new { brewery = brewery },
                new
                {
                    title = String.Format("See all posts in {0}", brewery.UrlSlug)
                });
        }
    }
}