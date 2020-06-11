using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Team_Golf.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
