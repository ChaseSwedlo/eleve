﻿namespace RestaurantProject.Models {
    public class Location {
        public int LocationId { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
