using BuissnesLayer.Services;
using DataLayer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebHostEnvironment _hostingEnvironment;
        private ServicesManager _servicesManager;

        public HomeController(ILogger<HomeController> logger, DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _servicesManager = new ServicesManager(dataManager);
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
