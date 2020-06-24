using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Golf.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Team_Golf.Repositories
{
    public class GolfCourseRepository : IRepository<GolfCourse>
    {
        private GolfCourseContext db;
        public GolfCourseRepository(GolfCourseContext db)
        {
            this.db = db;
        }

        public IEnumerable<GolfCourse> GetAll()
        {
            return db.GolfCourses;
        }

        public GolfCourse GetById(int id)
        {
            return db.GolfCourses.Single(c => c.Id == id);
        }

        public int Count()
        {
            return db.GolfCourses.Count();
        }

        public void Create(GolfCourse golfcourse)
        {
            db.GolfCourses.Add(golfcourse);
            db.SaveChanges();
        }

        public void Delete(Review review)
        {
            throw new NotImplementedException();
        }

        public void Update(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
