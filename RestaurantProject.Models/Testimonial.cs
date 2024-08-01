namespace RestaurantProject.Models {
    public class Testimonial {
        public int TestimonialId { get; set; }
        public string Review { get; set; }
        public string ChefImage { get; set; }
        public string ChefName { get; set; }
        public decimal Rating { get; set; }
    }
}
