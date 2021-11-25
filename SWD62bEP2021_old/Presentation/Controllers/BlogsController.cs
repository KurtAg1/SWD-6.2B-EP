using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class BlogsController : Controller
    {
        private IBlogsService blogsService;
        private ICategoriesService categoriesService;

        public BlogsController(IBlogsService _blogsService, ICategoriesService _categoriesService)
        {
            blogsService = _blogsService;
            categoriesService = _categoriesService;
        }

        public IActionResult Index()
        {
            var list = blogsService.GetBlogs();
            return View(list);
        }

        // this is going to load the page; this runs before the page is rendered.
        public IActionResult Create()
        {
            ViewBag.Categories = categoriesService.GetCategories();
            return View();
        }
    }
}
