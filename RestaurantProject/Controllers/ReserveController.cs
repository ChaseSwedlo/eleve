using Microsoft.AspNetCore.Mvc;
using RestaurantProject.BLL;
using RestaurantProject.Models;

namespace RestaurantProject.Controllers {
    public class ReserveController : Controller {
        private readonly ReservationService _reservationService;
        private readonly LocationService _locationService;

        public ReserveController (ReservationService reservationService, LocationService locationService)
        {
            _reservationService = reservationService;
            _locationService = locationService;
        }

        // Show Reservation Form
        // Read Locations
        [HttpGet]
        public IActionResult Index()
        {
            var model = new ReserveViewModel
            {
                Locations = _locationService.GetLocations()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ReserveViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var newReservation = new Reservation
                {
                    Name = viewModel.Name,
                    NumOfPeople = viewModel.NumOfPeople ?? 0,
                    Location = _locationService.GetLocation(viewModel.LocationId),
                    ReservationDateTime = viewModel.ReservationDateTime ?? DateTime.Now
                };

                _reservationService.AddReservation(newReservation);

                var model = new ReserveViewModel
                {
                    Locations = _locationService.GetLocations() ?? new List<Location>()
                };

                TempData["Message"] = $"Your reservation is on {newReservation.ReservationDateTime} at {newReservation.Location.Name}";

                return View(model);
            }

            viewModel.Locations = _locationService.GetLocations();
            return View(viewModel);
        }

    }
}
