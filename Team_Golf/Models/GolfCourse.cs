using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Team_Golf.Models
{
    public class GolfCourse
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string CourseType { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public GolfCourse()
        {

        }

        public GolfCourse(string name, int id, string description, string image, string courseType)
        {
            Name = name;
            Id = id;
            Description = description;
            Image = image;
            CourseType = courseType;

        }
    }

}
