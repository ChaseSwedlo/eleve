using Microsoft.AspNetCore.Mvc;

namespace RestaurantProject.Controllers {
    public class MenuController : Controller {
        /*
         * Read Appetizers
         * Read Entress
         * Read Deserts
         * Read Drinks
         */
        public IActionResult Index() {
            return View();
        }
    }
}
