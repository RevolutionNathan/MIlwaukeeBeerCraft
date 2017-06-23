using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MilwaukeeBeerCraft.Models;
using MilwaukeeBeerCraft.Controllers;
using MilwaukeeBeerCraft;
using Ninject;
using Ninject.Web;
using System.Web.Mvc;
using System.Web;

namespace MilwaukeeBeerCraft.Controllers
{
        public class BlogController: Controller
    {
        private readonly BlogRepository _blogRespository;

        public BlogController(BlogRepository blogRepository)
        {
            _blogRespository = blogRepository;
        }

        public ViewResult List(int p = 1)
        {
            // pick latest 10 posts
            var viewModel = new ListViewModel(_blogRespository, p); 
            ViewBag.Title = "Latest Posts";

            return View("List", viewModel);
        }
        public ViewResult Category(string category, int p = 1)
        {
            var viewModel = new ListViewModel(_blogRespository, category, p);

            if (viewModel.Category == null)
                throw new HttpException(404, "Category not found");

            ViewBag.Title = String.Format(@"Latest posts on category ""{0}""",
                                viewModel.Category.Name);
            return View("List", viewModel);
        }
        [ChildActionOnly]
        public PartialViewResult SubHeadings()
        {
            var widgetViewModel = new WidgetViewModel(_blogRespository);
            return PartialView("_Sidebars", widgetViewModel);
        }

    }
}
