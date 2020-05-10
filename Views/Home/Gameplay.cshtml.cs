using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace End_of_all_Hope.Views.Home {
    public class GameplayModel : PageModel {
        private readonly ILogger<GameplayModel> _logger;

        public GameplayModel (ILogger<GameplayModel> logger) {
            _logger = logger;
        }
        public void OnGet () { }
    }
}