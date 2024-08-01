namespace RestaurantProject.Models {
    public class Promotion {
        public int PromotionId { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Discount { get; set; }
        public DateTime DateTime { get; set; }
    }
}
