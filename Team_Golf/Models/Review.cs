using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team_Golf.Models
{
    public class Review
    {
        [Required]
        public string ReviewerName { get; set; }
        public int Id { get; set; }
        [Required]
        public string ReviewText { get; set; }
        public string ReviewDate { get; set; }
        public int ReviewRating { get; set; }

        public int GolfCourseId { get; set; }
        public virtual GolfCourse GolfCourse { get; set; }

        public Review()
        {

        }
        public Review(string reviewerName, int reviewId, string reviewText, string reviewDate, int reviewRating, int golfCourseId)
        {
            ReviewerName = reviewerName;
            Id = reviewId;
            ReviewText = reviewText;
            ReviewDate = reviewDate;
            ReviewRating = reviewRating;
            GolfCourseId = golfCourseId;
        }
    }
}
