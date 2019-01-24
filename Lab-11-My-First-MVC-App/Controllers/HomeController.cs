using Lab_11_My_First_MVC_App.Models;
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

        /// <summary>
        /// Making an HTTP Post request for action
        /// </summary>
        /// <param name="begYear"></param>
        /// <param name="endYear"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(int begYear, int endYear)
        {
            // redirects to the results action, given parameters
            return RedirectToAction("Result", new { begYear, endYear });
        }


        public ViewResult Result(int begYear, int endYear)
        {
            //Creates a list of TimePerson file that match criteria
            List<TimePerson> list = TimePerson.GetPersons(begYear, endYear);
            return View(list);
        }
    }
}
