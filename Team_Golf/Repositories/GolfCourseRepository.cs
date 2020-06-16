using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Golf.Models;

namespace Team_Golf.Repositories
{
    public class GolfCourseRepository : IRepository<GolfCourse>
    {
        public List<GolfCourse> golfCoursesList;

        public GolfCourseRepository()
        {
            golfCoursesList = new List<GolfCourse>()
            {
                new GolfCourse("Bushwood CC", 1, "Good snack shack and poor caddying","Bushwood.jpg"),
                new GolfCourse("Fury Creek Golf CC", 2, "Price is wrong B&$#%","FurryCreek.jpg"),
                new GolfCourse("Cotton Wood", 3, "Waggle and let the big dog eat","Cottonwood.jpg")
            };
        }

        public IEnumerable<GolfCourse> GetAll()
        {
            return golfCoursesList;
        }

        public GolfCourse GetById(int id)
        {
            return golfCoursesList.Single(c => c.Id == id);
        }
    }
}
