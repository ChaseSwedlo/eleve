using RestaurantProject.Models;

namespace RestaurantProject.DAL {
    public class AppetizerDAL {
        private readonly RestaurantProjectContext _context;

        public AppetizerDAL(RestaurantProjectContext context) {
            _context = context;
        }

        public List<Appetizer> GetAppetizers() {
            return _context.Appetizers.ToList();
        }
    }
}
