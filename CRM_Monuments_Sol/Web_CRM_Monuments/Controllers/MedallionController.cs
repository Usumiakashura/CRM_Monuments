using BuissnesLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_CRM_Monuments.Models;
using Web_CRM_Monuments.Services;

namespace Web_CRM_Monuments.Controllers
{
    public class MedallionController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataManager _dataManager;
        private ServicesManager _servicesManager;

        public MedallionController(ILogger<HomeController> logger, DataManager dataManager)
        {
            _logger = logger;
            _dataManager = dataManager;
            _servicesManager = new ServicesManager(_dataManager);
        }

        [HttpGet]
        public ActionResult AllMeedallions()
        {
            var m = _servicesManager.Medallions.GetAllMedallions();
            return PartialView("_AllMedallionsPartial", m);
        }

        [HttpGet]
        public ActionResult Details(int idMedallion)
        {
            return View(DBMedallionToView(idMedallion));
        }

        [HttpPost]
        public ActionResult CompleateOn(int idMedallion, string date)
        {
            DateTime d = DateTime.Parse(date);
            _dataManager.PhotosOnMonuments.CompleateOn(idMedallion, d);
            return View("Details", DBMedallionToView(idMedallion));
        }
        //-------------------------------------------
        private MedallionViewModel DBMedallionToView(int idMedallion)
        {
            MedallionViewModel medallion = new MedallionViewModel();
            if (idMedallion > 0)
            {
                medallion = _servicesManager.Medallions.GetMedallionById(idMedallion);
            }
            return medallion;
        }
    }
}
