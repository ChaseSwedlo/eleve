using RestaurantProject.Models;

namespace RestaurantProject.DAL {
    public class DesertDAL {
        private readonly RestaurantProjectContext _context;

        public DesertDAL(RestaurantProjectContext context) {
            _context = context;
        }

        public List<Desert> GetDeserts() {
            return _context.Deserts.ToList();
        }
    }
}
