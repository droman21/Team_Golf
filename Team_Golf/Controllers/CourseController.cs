using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team_Golf.Models;
using Team_Golf.Repositories;

namespace Team_Golf.Controllers
{
    public class CourseController : Controller
    {
        IRepository<GolfCourse> golfCourseRepo;

        public CourseController(IRepository<GolfCourse> golfCourseRepo)
        {
            this.golfCourseRepo = golfCourseRepo;
        }

        public ViewResult Index()
        {
            //GolfCourseRepository golfCourseRepo = new GolfCourseRepository();
            var model = golfCourseRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = golfCourseRepo.GetById(id);
            return View(model);
        }
    }
}
