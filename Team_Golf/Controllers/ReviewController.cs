using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team_Golf.Models;
using Team_Golf.Repositories;

namespace Team_Golf.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Review review)
        {
            if (ModelState.IsValid)
            {
                reviewRepo.Create(review);
                return RedirectToAction("Details", "Course", new { id = review.GolfCourseId });
            }
            return View(review);
        }

        [HttpGet]
        public ViewResult CreateByGolfCourseID(int Id)
        {
            ViewBag.GolfCourseID = Id;
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            Review review = reviewRepo.GetById(id);
            return View(review);
        }
        [HttpPost]
        public ActionResult Delete (Review review)
        {
            int golfCourseID = review.GolfCourseId;
            reviewRepo.Delete(review);
            //return RedirectToAction("Details", "Course", new { id = review.GolfCourseId });
            return RedirectToAction("Details", "Course", new { id = golfCourseID });
            //return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Update(int id)
        {
            Review review = reviewRepo.GetById(id);
            return View(review);
        }
        [HttpPost]
        public ActionResult Update(Review review)
        {
            int golfCourseID = review.GolfCourseId;
            reviewRepo.Update(review);
            return RedirectToAction("Details", "Course", new { id = golfCourseID });
        }

    }
}
