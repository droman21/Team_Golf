using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Golf.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Team_Golf.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        private GolfCourseContext db;
        public ReviewRepository(GolfCourseContext db)
        {
            this.db = db;
        }

        public IEnumerable<Review> GetAll()
        {
            return db.Reviews;
        }

        public Review GetById(int id)
        {
            return db.Reviews.Single(c => c.Id == id);
        }

        public int Count()
        {
            return db.Reviews.Count();
        }

        public void Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }
        public void Delete(Review review)
        {
            db.Reviews.Remove(review);
            db.SaveChanges();
        }
    }
}
