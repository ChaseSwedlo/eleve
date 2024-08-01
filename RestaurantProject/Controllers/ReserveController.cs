using Microsoft.AspNetCore.Mvc;

namespace RestaurantProject.Controllers {
    public class ReserveController : Controller {
        /*
         * Add Reservations
         * Read Locations 
         */
        public IActionResult Index() {
            return View();
        }
    }
}
