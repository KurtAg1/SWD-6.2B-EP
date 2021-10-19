using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        // Role: To render the page
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Role: To service the button submit
        [HttpPost]

        public IActionResult HandleQuery(string query)
        {

            // 1st approach: ViewBag is a way how you can pass any type of data from the Controller to the View.
            // 2nd approach: using models and then you pass the model instance to the View.
            // 3rd approach: ViewData is like ViewBag but you have to se it as a dictionary.
            // 4th approach: TempData is like ViewData but it survives postbacks.
            // 5th approach: Sessions is an upgrade to Tempdata because it survives all the postbacks.

            if (string.IsNullOrEmpty(query) == false)
                ViewBag.Message = "Thanks. We've received your query.";
            else
                ViewBag.Error = "No query received. Please type something.";
            
            

            return View("index");
        }
    }
}
