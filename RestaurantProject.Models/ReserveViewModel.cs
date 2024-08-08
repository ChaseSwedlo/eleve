using System.ComponentModel.DataAnnotations;

namespace RestaurantProject.Models {
    public class ReserveViewModel {
        [Required]
        public int LocationId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 16, ErrorMessage = "Max party of 16")]
        public int? NumOfPeople { get; set; }
        [Required]
        public DateTime? ReservationDateTime { get; set; } = DateTime.Now;
        public List<Location> Locations { get; set; } = new List<Location>();
    }
}
