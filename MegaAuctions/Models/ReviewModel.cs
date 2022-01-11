using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaAuctions.Models
{
    public class ReviewModel
    {
        DBEntitiesAuction db = new DBEntitiesAuction();
        public IEnumerable<Review> ListReview()
        {
            return db.Reviews.ToList();
        }

    }
}