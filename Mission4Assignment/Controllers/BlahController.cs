using Microsoft.AspNetCore.Mvc;
using Mission4Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Controllers
{
    //controller page
    public class BlahController : Controller
    {
        //for home page
        public IActionResult Index()
        {
            return View();
        }
        //gets input

        [HttpGet]
        public IActionResult GradeC()
        {
            return View();
        }
        //posts input

        [HttpPost]
        public IActionResult GradeC(GradeCModel model)
        {
            return View();
        }
    }
}
