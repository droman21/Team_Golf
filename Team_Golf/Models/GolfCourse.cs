using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Golf.Models
{
    public class GolfCourse
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Review { get; set; }

        public GolfCourse()
        {

        }

        public GolfCourse(string name, int id, string review)
        {
            Name = name;
            Id = id;
            Review = review;
        }
        
    }

}
