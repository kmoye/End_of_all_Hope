using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using End_of_all_Hope.Models;
using End_of_all_Hope.DAL;

namespace End_of_all_Hope.Controllers
{
	public class HomeController : Controller
	{
		private GameContext db;
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger, GameContext gameContext)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			ViewData["users"] = db.Users.ToList();

			return View(ViewData);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
