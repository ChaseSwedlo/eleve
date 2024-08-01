using RestaurantProject.DAL;
using RestaurantProject.Models;

namespace RestaurantProject.BLL {
    public class PromotionService {

        private readonly PromotionDAL _promotionDAL;

        public PromotionService(PromotionDAL promotionDAL) {
            _promotionDAL = promotionDAL;
        }

        public List<Promotion> GetPromotions() {
            return _promotionDAL.GetPromotions();
        }

        public Promotion GetPromotion(int id) {
            return _promotionDAL.GetPromotion(id);
        }

        public void AddPromotion(Promotion promotion) {
            _promotionDAL.AddPromotion(promotion);
        }

        public void DeletePromotion(int id) {
            _promotionDAL.DeletePromotion(id);
        }

        public void UpdatePromotion(Promotion promotion) {
            _promotionDAL.UpdatePromotion(promotion);
        }
    }
}
