using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GoldReviews.Domain;

namespace GoldReviews.Service
{
    /// <summary>
    /// Summary description for ReviewsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class ReviewsService : System.Web.Services.WebService
    {
        private readonly ReviewContext _context;

        public ReviewsService()
        {
            _context = new ReviewContext();
        }

        [WebMethod]
        public IEnumerable<Review> GetAllReviews()
        {
            return _context.Reviews.ToList();
        }
    }
}
