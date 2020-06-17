using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Golf.Models
{
    public class ReviewModels
    {
        public string Reviewer_Name { get; set; }
        public int Review_Id { get; set; }
        public string Review { get; set; }
        public DateTime Review_Date { get; set; }
        public int Review_Rating { get; set; }

        public ReviewModels()
        {

        }
        public ReviewModels(string reviewer_name, int review_id, string review, DateTime review_date, int review_rating)
        {
            Reviewer_Name = reviewer_name;
            Review_Id = review_id;
            Review = review;
            Review_Date = review_date;
            Review_Rating = review_rating;
        }
    }
}
