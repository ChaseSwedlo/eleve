using RestaurantProject.DAL;
using RestaurantProject.Models;

namespace RestaurantProject.BLL {
    public class TestimonialService {
        private readonly TestimonialDAL _testimonialDAL;

        public TestimonialService(TestimonialDAL testimonialDAL) {
            _testimonialDAL = testimonialDAL;
        }

        public List<Testimonial> GetTestimonials() {
            return _testimonialDAL.GetTestimonials();
        }
    }
}
