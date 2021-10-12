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
            return View();
        }
    }
}
