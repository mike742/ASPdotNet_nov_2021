using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNet_nov_2021.Controllers
{
    public class TestController : Controller
    {
        public string Index()
        {
            return "Hello World!!!";
        }

        public IActionResult OkResult(int id)
        {
            return Ok($"You have entered {id}");
        }

        public IActionResult Redirect()
        {
            return Redirect("https://google.com");
        }

        public IActionResult Json()
        {
            return Json(new { 
                message = "this is a JSON result",
                date = DateTime.Now
            });
        }

        public IActionResult Content()
        {
            return Content("Hello <b>Content</b>");
        }
    }
}
