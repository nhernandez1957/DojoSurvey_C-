using System;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    public class Form : Controller
    {
        [HttpGet]

        [Route("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("postForm")]
        public IActionResult postForm(string name, string location, string language, string area)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Location: {location}");
            Console.WriteLine($"Language: {language}");
            Console.WriteLine($"Comments: {area}");
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comments = area;
            return View("Success");
        }

        [HttpGet("Success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}