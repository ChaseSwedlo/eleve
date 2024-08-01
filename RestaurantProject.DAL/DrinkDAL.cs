using RestaurantProject.Models;

namespace RestaurantProject.DAL {
    public class DrinkDAL {
        private readonly RestaurantProjectContext _context;

        public DrinkDAL(RestaurantProjectContext context) {
            _context = context;
        }

        public List<Drink> GetDrinks() {
            return _context.Drinks.ToList();
        }
    }
}
