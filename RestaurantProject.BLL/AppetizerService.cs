using RestaurantProject.DAL;
using RestaurantProject.Models;

namespace RestaurantProject.BLL {
    public class AppetizerService {
        private readonly AppetizerDAL _appetizerDAL;

        public AppetizerService(AppetizerDAL appetizerDAL) {
            _appetizerDAL = appetizerDAL;
        }

        public List<Appetizer> GetAppetizers() {
            return _appetizerDAL.GetAppetizers();
        }
    }
}
