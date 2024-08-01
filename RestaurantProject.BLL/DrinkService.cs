using RestaurantProject.DAL;
using RestaurantProject.Models;

namespace RestaurantProject.BLL {
    public class DrinkService {
        private readonly DrinkDAL _drinkDAL;

        public DrinkService(DrinkDAL drinkDAL) {
            _drinkDAL = drinkDAL;
        }

        public List<Drink> GetDrinks() {
            return _drinkDAL.GetDrinks();
        }
    }
}
