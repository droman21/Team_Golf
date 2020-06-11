using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team_Golf.Models;

namespace Team_Golf.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            GolfCourse model = new GolfCourse("St. Ron of Scotland", 1, "Good snack shack and poor caddying");
            return View(model);
        }
    }
}
