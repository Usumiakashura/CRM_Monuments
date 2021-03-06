using DataLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuissnesLayer.Models;
using BuissnesLayer.Services;

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
            var m = _servicesManager.Medallions.GetAllMedallionViews();
            return PartialView("_AllMedallionsPartial", m);
        }

        [Authorize(Roles = "manager,admin")]
        [HttpGet]
        public ActionResult Details(int idMedallion)
        {
            return View(_servicesManager.Medallions.GetMedallionViewById(idMedallion));
        }

        [HttpPost]
        public ActionResult CompleateOn(int idMedallion, string date)
        {
            DateTime d = DateTime.Parse(date);
            _dataManager.PhotosOnMonuments.CompleateOn(idMedallion, d);
            return View("Details", _servicesManager.Medallions.GetMedallionViewById(idMedallion));
        }
        //-------------------------------------------
        //private MedallionViewModel DBMedallionToView(int idMedallion)
        //{
        //    MedallionViewModel medallion = new MedallionViewModel();
        //    if (idMedallion > 0)
        //    {
        //        medallion = _servicesManager.Medallions.GetMedallionById(idMedallion);
        //    }
        //    return medallion;
        //}
    }
}
