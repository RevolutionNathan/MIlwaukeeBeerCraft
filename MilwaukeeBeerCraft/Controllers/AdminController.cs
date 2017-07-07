using MilwaukeeBeerCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilwaukeeBeerCraft.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageContent()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            ListViewModel listView = new ListViewModel();

            var posts = new ApplicationDbContext().Post.ToList();
            var beersInStyle = db.Beer.Select(s => s.beer_style).ToList();
            var categories = db.Category.Select(s => s.Name).ToList();
            var breweries = db.MilwaukeeBreweries.Select(s => s.Name).ToList();

            listView.TotalPosts = posts.Count();
            listView.Posts = posts;
            listView.beerStyles = beersInStyle;
            listView.category = categories;
            listView.breweries = breweries;

            return View(listView);
        }

        public ActionResult ManagePosts()
        {
            List<Post> Posts = new List<Post>();
            ApplicationDbContext context = new ApplicationDbContext();
            var posts = context.Post.ToList();

            return View(posts);
        }

        [HttpPost]
        public ActionResult Post(Post incomingPost)
        {
            Post newPost = new Post();
            {
                newPost.Beer = incomingPost.Beer;
                newPost.Content = incomingPost.Content;
                newPost.Brewery = incomingPost.Brewery;
                newPost.Category = incomingPost.Category;
                newPost.PostedOn = DateTime.Now;
                newPost.Published = true;
            }

            context.Post.Add(newPost);
            context.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

        public ActionResult DeletePost(int id)
        {
            List<Post> Posts = new List<Post>();
            ApplicationDbContext context = new ApplicationDbContext();
            var postToDelete = context.Post.SingleOrDefault(c => c.Id == id);
            context.Post.Remove(postToDelete);
            context.SaveChanges();

            return RedirectToAction("ManageContent", "Admin");
        }



    }
}