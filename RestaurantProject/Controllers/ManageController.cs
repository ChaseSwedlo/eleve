using Microsoft.AspNetCore.Mvc;
using RestaurantProject.BLL;
using RestaurantProject.Models;

namespace RestaurantProject.Controllers {
    public class ManageController : Controller {
        /*
         * Create-Read-Update-Delete Promotions - Create-read-update-delete done
         * Read-Delete Reservations - done
         * Read-Update Locations - done
         * 
         * adding update reservations
         */
        private readonly ReservationService _reservationService;
        private readonly PromotionService _promotionService;
        private readonly LocationService _locationService;

        public ManageController(ReservationService reservationService, PromotionService promotionService, LocationService locationService) {
            _reservationService = reservationService;
            _promotionService = promotionService;
            _locationService = locationService;
        }

        public IActionResult Index() {
            List<Reservation> reservations = _reservationService.GetReservations();
            List<Promotion> promotions = _promotionService.GetPromotions();
            List<Location> locations = _locationService.GetLocations();
            ManageViewModel mvm = new ManageViewModel {
                Reservations = reservations,
                Promotions = promotions,
                Locations = locations
            };
            return View(mvm);
        }

        public IActionResult DeleteReservation(int id) {
            _reservationService.DeleteReservation(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePromo(int id) {
            var updatedPromo = _promotionService.GetPromotion(id);
            if (updatedPromo == null) {
                return NotFound();
            }
            return View(updatedPromo);
        }

        [HttpPost]
        public IActionResult UpdatePromo(Promotion p) {
            if (ModelState.IsValid) {
                _promotionService.UpdatePromotion(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult UpdateLocation(int id) {
            var updatedLocation = _locationService.GetLocation(id);
            if (updatedLocation == null) {
                return NotFound();
            }
            return View(updatedLocation);
        }

        [HttpPost]
        public IActionResult UpdateLocation(Location l) {
            if (ModelState.IsValid) {
                _locationService.UpdateLocation(l);
                return RedirectToAction("Index");
            }
            return View(l);
        }

        [HttpGet]
        public IActionResult UpdateReservation(int id) {
            var reservation = _reservationService.GetReservation(id);
            if (reservation == null) {
                return NotFound();
            }

            var viewModel = new UpdateReservationViewModel {
                ReservationId = reservation.ReservationId,
                LocationId = reservation.LocationId,
                Name = reservation.Name,
                NumOfPeople = reservation.NumOfPeople,
                ReservationDateTime = reservation.ReservationDateTime
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult UpdateReservation(UpdateReservationViewModel viewModel) {
            if (ModelState.IsValid) {
                var reservation = new Reservation {
                    ReservationId = viewModel.ReservationId,
                    LocationId = viewModel.LocationId,
                    Name = viewModel.Name,
                    NumOfPeople = viewModel.NumOfPeople,
                    ReservationDateTime = viewModel.ReservationDateTime
                };

                _reservationService.UpdateReservation(reservation);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PromotionViewModel p) {
            if (ModelState.IsValid) {
                Promotion newPromotion = new Promotion {
                    Image = p.Image,
                    Name = p.Name,
                    Description = p.Description,
                    Discount = p.Discount,
                    DateTime = p.DateTime
                };
                _promotionService.AddPromotion(newPromotion);
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}