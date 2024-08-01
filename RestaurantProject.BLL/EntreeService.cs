using RestaurantProject.DAL;
using RestaurantProject.Models;

namespace RestaurantProject.BLL {
    public class EntreeService {
        private readonly EntreeDAL _entreeDAL;

        public EntreeService(EntreeDAL entreeDAL) {
            _entreeDAL = entreeDAL;
        }
        public List<Entree> GetEntrees() {
            return _entreeDAL.GetEntrees();
        }
    }
}