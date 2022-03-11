using BuissnesLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_CRM_Monuments.Services;

namespace Web_CRM_Monuments.Controllers
{
    public class TestController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebHostEnvironment _hostingEnvironment;
        private DataManager _dataManager;
        private ServicesManager _servicesManager;

        public TestController(ILogger<HomeController> logger, DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _dataManager = dataManager;
            _servicesManager = new ServicesManager(_dataManager);
            _hostingEnvironment = hostingEnvironment;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Test()
        {
            IEnumerable<PhotoOnMonument> photos;


            photos = _dataManager.PhotosOnMonuments.GetAllPhotoOnMonumentsByIdDeceased(4);




            return View("Index");
        }
    }
}
