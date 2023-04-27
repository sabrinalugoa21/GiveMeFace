using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GiveMeFace.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Face()
        {
            return View();
        }

        public IActionResult Eyes()
        {
            return View();
        }

        public IActionResult Brows()
        {
            return View();
        }

        public IActionResult Lips()
        {
            return View();
        }
    }
}