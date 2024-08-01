using System.ComponentModel.DataAnnotations;

namespace RestaurantProject.Models {
    public class PromotionViewModel {
        [Required]
        public string Image { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Discount { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
