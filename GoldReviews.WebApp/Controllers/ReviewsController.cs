using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using GoldReviews.Domain;
using GoldReviews.Service;
using GoldReviews.WebApp.Models;

namespace GoldReviews.WebApp.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ReviewContext _reviewContext;
        private readonly ReviewsService _service;
        private readonly MapperConfiguration _configuration;

        public ReviewsController()
        {
            _reviewContext = new ReviewContext();
            _service = new ReviewsService();
            _configuration = new MapperConfiguration(c => { c.CreateMap<ReviewViewModel, Review>(); });
        }

        // GET: Reviews
        public ActionResult Index()
        {
            return View(_reviewContext.Reviews.OrderByDescending(r => r.Id).ToList());
        }
        
        [HttpPost]
        public ActionResult Create(ReviewViewModel reviewViewModel)
        {
            var mapper = _configuration.CreateMapper();
            var review = mapper.Map<Review>(reviewViewModel);

            if (ModelState.IsValid)
            {
                _reviewContext.Reviews.Add(review);
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
