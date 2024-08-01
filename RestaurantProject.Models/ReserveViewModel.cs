using System.ComponentModel.DataAnnotations;

namespace RestaurantProject.Models {
    public class ReserveViewModel {
        [Required]
        public int LocationId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int NumOfPeople { get; set; }
        [Required]
        public DateTime ReservationDateTime { get; set; }
        public List<Location> Locations { get; set; }
    }
}
