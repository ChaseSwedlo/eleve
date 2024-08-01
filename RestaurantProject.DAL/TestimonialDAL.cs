using RestaurantProject.Models;

namespace RestaurantProject.DAL {
    public class TestimonialDAL {
        private readonly RestaurantProjectContext _context;

        public TestimonialDAL(RestaurantProjectContext context) {
            _context = context;
        }

        public List<Testimonial> GetTestimonials() {
            return _context.Testimonials.ToList();
        }
    }
}
