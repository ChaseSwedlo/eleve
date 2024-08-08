using Microsoft.AspNetCore.Mvc;
using RestaurantProject.BLL;
using RestaurantProject.Models;
using System.Diagnostics;

namespace RestaurantProject.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly PromotionService _promotionService;
        private readonly TestimonialService _testimonialService;

        public HomeController(ILogger<HomeController> logger, PromotionService promotionService, TestimonialService testimonialService) {
            _logger = logger;
            _promotionService = promotionService;
            _testimonialService = testimonialService;
        }

        public IActionResult Index() {
            List<Promotion> promotionList = _promotionService.GetPromotions();
            List<Testimonial> testimonialList = _testimonialService.GetTestimonials();
            var viewModel = new MainViewModel {
                Promotions = promotionList,
                Testimonials = testimonialList
            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
