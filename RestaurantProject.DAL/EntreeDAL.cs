using RestaurantProject.Models;

namespace RestaurantProject.DAL {
    public class EntreeDAL {
        private readonly RestaurantProjectContext _context;

        public EntreeDAL(RestaurantProjectContext context) {
            _context = context;
        }

        public List<Entree> GetEntrees() {
            return _context.Entrees.ToList();
        }
    }
}
