namespace RestaurantProject.Models {
    public class Reservation {
        public int ReservationId { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public int NumOfPeople { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public virtual Location Location { get; set; } = null!;
    }
}
