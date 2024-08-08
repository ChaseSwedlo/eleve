using Microsoft.AspNetCore.Mvc;
using RestaurantProject.BLL;
using RestaurantProject.Models;

namespace RestaurantProject.Controllers
{
    public class MenuController : Controller
	{
		/*
         * Read Appetizers
         * Read Entress
         * Read Deserts
         * Read Drinks
         */
		
		private readonly AppetizerService _appetizerService;
		private readonly EntreeService _entreeService;
		private readonly DesertService _desertService;
		private readonly DrinkService _drinkService;

		public MenuController(AppetizerService appetizerService, EntreeService entreeService, DesertService desertService, DrinkService drinkService)
		{

			_appetizerService = appetizerService;
			_entreeService = entreeService;
			_desertService = desertService;
			_drinkService = drinkService;
		}

        public IActionResult Index()
		{
			var appetizers = _appetizerService.GetAppetizers();
			var entrees = _entreeService.GetEntrees();
			var deserts = _desertService.GetDeserts();
			var drinks = _drinkService.GetDrinks();

			var menuViewModel = new MenuViewModel
			{
				Appetizers = appetizers,
				Entrees = entrees,
				Deserts = deserts,
				Drinks = drinks
			};

			return View(menuViewModel);

		}


	}
}
