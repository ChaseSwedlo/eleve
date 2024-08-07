using Microsoft.AspNetCore.Mvc;
using RestaurantProject.BLL;
using RestaurantProject.Models;

namespace RestaurantProject.Controllers {
    public class MainController : Controller {
        private readonly PromotionService _promotionService;
        private readonly TestimonialService _testimonialService;
        
        public MainController (PromotionService promotionService, TestimonialService testimonialService)
        {
            _promotionService = promotionService;
            _testimonialService = testimonialService;
        }


        //Read Promotions
        //Read Testimonials
        public IActionResult Index()
        {
            List<Promotion> promotionList = _promotionService.GetPromotions();
            List<Testimonial> testimonialList = _testimonialService.GetTestimonials();
            var viewModel = new MainViewModel
            {
                Promotions = promotionList,
                Testimonials = testimonialList
            };
            return View(viewModel);
        }
    }
}
