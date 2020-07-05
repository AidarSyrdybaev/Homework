using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HomeWorkApplication.Models;
using HomeWorkApplication.Services.Contracts;

namespace HomeWorkApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IHomeService _homeService;

        public HomeController(ILogger<HomeController> logger, IHomeService homeService)
        {
            _homeService = homeService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var CafeesModel = _homeService.GetCafeViewModels();
            return View(CafeesModel);
        }

        public IActionResult Details(int Id)
        {
            var CafeModel = _homeService.GetCafeDetailsModel(Id);
            return View(CafeModel);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
