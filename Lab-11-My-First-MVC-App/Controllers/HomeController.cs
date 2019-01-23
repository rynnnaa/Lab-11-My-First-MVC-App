using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_11_My_First_MVC_App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           

            return View();
        }

        [HttpPost]

        public IActionResult Index(int firstNumber, int secondNumber)
        {
            return RedirectToAction("Results", new { firstNumber, secondNumber });
        }

        public IActionResult Results(int firstNumber, int secondNumber)
        {
            //do what we want with the numbers

            return View();
        }
    }
}
