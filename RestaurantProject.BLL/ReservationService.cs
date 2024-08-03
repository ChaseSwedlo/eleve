using RestaurantProject.DAL;
using RestaurantProject.Models;

namespace RestaurantProject.BLL {
    public class ReservationService {
        private readonly ReservationDAL _reservationDAL;

        public ReservationService(ReservationDAL reservationDAL) {
            _reservationDAL = reservationDAL;
        }
        public List<Reservation> GetReservations() { 
            return _reservationDAL.GetReservations();
        }

        public Reservation GetReservation(int id) {
            return _reservationDAL.GetReservation(id);
        }

        public void AddReservation(Reservation reservation) {
            _reservationDAL.AddReservation(reservation);
        }

        public void DeleteReservation(int id) {
            _reservationDAL.DeleteReservation(id);
        }

        public void UpdateReservation(Reservation reservation) {
            _reservationDAL.UpdateReservation(reservation);
        }
    }
}
