using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Golf.Models;
//using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Team_Golf.Repositories
{
    public class GolfCourseRepository : IRepository<GolfCourse>
    {
        //public List<GolfCourse> golfCoursesList;
        private GolfCourseContext db;
        public GolfCourseRepository(GolfCourseContext db)
        {
            this.db = db;
        }

        //public GolfCourseRepository()
        //{
        //    golfCoursesList = new List<GolfCourse>()
        //    {
        //        
        //    };
        //}

        public IEnumerable<GolfCourse> GetAll()
        {
            return db.GolfCourse;
        }

        public GolfCourse GetById(int id)
        {
            return golfCoursesList.Single(c => c.Id == id);
        }
        
        
    }
}
