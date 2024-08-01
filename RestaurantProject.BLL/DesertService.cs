using RestaurantProject.DAL;
using RestaurantProject.Models;

namespace RestaurantProject.BLL {
    public class DesertService {
        private readonly DesertDAL _desertDAL;

        public DesertService(DesertDAL desertDAL) {
            _desertDAL = desertDAL;
        }

        public List<Desert> GetDeserts() {
            return _desertDAL.GetDeserts();
        }
    }
}
