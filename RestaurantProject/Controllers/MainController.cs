using Microsoft.AspNetCore.Mvc;

namespace RestaurantProject.Controllers {
    public class MainController : Controller {
        /*
         * Read Promotions
         * Read Testimonials
         */
        public IActionResult Index() {
            return View();
        }
    }
}
