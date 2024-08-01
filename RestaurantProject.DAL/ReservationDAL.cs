using RestaurantProject.Models;

namespace RestaurantProject.DAL {
    public class ReservationDAL {
        private readonly RestaurantProjectContext _context;

        public ReservationDAL(RestaurantProjectContext context) {
            _context = context;
        }

        public List<Reservation> GetReservations() {
            return _context.Reservations.ToList();
        }

        public Reservation GetReservation(int id) {
            return _context.Reservations.Find(id);
        }

        public void AddReservation(Reservation reservation) {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }

        public void DeleteReservation(int id) {
            var reservation = _context.Reservations.Find(id);
            if (reservation != null) {
                _context.Reservations.Remove(reservation);
                _context.SaveChanges();
            }
        }
    }
}
