using RestaurantProject.Models;

namespace RestaurantProject.DAL {
    public class LocationDAL {
        private readonly RestaurantProjectContext _context;

        public LocationDAL(RestaurantProjectContext context) {
            _context = context;
        }

        public List<Location> GetLocations() {
            return _context.Locations.ToList();
        }

        public Location GetLocation(int id) {
            return _context.Locations.Find(id);
        }

        public void Update(Location location) {
            _context.Locations.Update(location);
            _context.SaveChanges();
        }
    }
}
