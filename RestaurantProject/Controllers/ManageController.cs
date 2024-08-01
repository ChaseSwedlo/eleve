using Microsoft.AspNetCore.Mvc;

namespace RestaurantProject.Controllers {
    public class ManageController : Controller {
        /*
         * Create-Read-Update-Delete Promotions
         * Read-Delete Reservations
         * Read-Update Locations
         */
        public IActionResult Index() {
            return View();
        }
    }
}
