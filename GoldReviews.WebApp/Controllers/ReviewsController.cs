using System.Linq;
using System.Web.Mvc;
using GoldReviews.Domain;
using GoldReviews.Service;
using GoldReviews.WebApp.Models;

namespace GoldReviews.WebApp.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ReviewContext _reviewContext = new ReviewContext();
        private readonly ReviewsService _service = new ReviewsService();

        // GET: Reviews
        public ActionResult Index()
        {
            return View(_reviewContext.Reviews.OrderByDescending(r => r.Id).ToList());
        }
        
        [HttpPost]
        public ActionResult Create(ReviewViewModel review)
        {
            var model = new Review()
            {
                ClientName = review.ClientName,
                ClientReview = review.ClientReview
            };

            if (ModelState.IsValid)
            {
                _reviewContext.Reviews.Add(model);
                _reviewContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult GetAllReviews()
        {
            var reviews = _service.GetAllReviews();

            return Json(reviews, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _reviewContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
