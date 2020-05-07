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
		private readonly GameContext _context;

		public HomeController(GameContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var UserId = 1;
			ViewBag.Items = _context.Items
				.Join(
					_context.UserItems,
					i => i.ItemID,
					ui => ui.ItemID,
					(i, ui) => new
					{
						ItemID = ui.ItemID,
						ItemTypeID = i.ItemTypeID,
						UserID = ui.UserID,
						Name = i.Name
					})
				.Where(ui => ui.UserID == UserId)
				.ToList();
			return View();
		}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
