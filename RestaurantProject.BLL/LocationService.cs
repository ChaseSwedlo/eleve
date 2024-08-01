using RestaurantProject.DAL;
using RestaurantProject.Models;

namespace RestaurantProject.BLL {
    public class LocationService {
        private readonly LocationDAL _locationDAL;

        public LocationService(LocationDAL locationDAL) {
            _locationDAL = locationDAL;
        }

        public List<Location> GetLocations() {
            return _locationDAL.GetLocations();
        }

        public Location GetLocation(int id) {
            return _locationDAL.GetLocation(id);
        }

        public void UpdateLocation(Location location) {
            _locationDAL.Update(location);
        }
    }
}
