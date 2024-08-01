using RestaurantProject.Models;

namespace RestaurantProject.DAL {
    public class PromotionDAL {
        private readonly RestaurantProjectContext _context;

        public PromotionDAL(RestaurantProjectContext context) {
            _context = context;
        }

        public List<Promotion> GetPromotions() {
            return _context.Promotions.ToList();
        }

        public Promotion GetPromotion(int id) {
            return _context.Promotions.Find(id);
        }

        public void AddPromotion(Promotion promotion) {
            _context.Promotions.Add(promotion);
            _context.SaveChanges();
        }

        public void UpdatePromotion(Promotion promotion) {
            _context.Promotions.Update(promotion);
            _context.SaveChanges();
        }

        public void DeletePromotion(int id) {
            var promo = _context.Promotions.Find(id);
            if (promo != null) {
                _context.Promotions.Remove(promo);
                _context.SaveChanges();
            }
        }
    }
}
