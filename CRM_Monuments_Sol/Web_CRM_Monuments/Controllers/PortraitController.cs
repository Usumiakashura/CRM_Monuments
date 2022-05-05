using DataLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class PortraitController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataManager _dataManager;
        private ServicesManager _servicesManager;

        public PortraitController(ILogger<HomeController> logger, DataManager dataManager)
        {
            _logger = logger;
            _dataManager = dataManager;
            _servicesManager = new ServicesManager(_dataManager);
        }

        [HttpGet]
        public ActionResult AllPortraits()
        {
            var p = _servicesManager.Portraits.GetAllPortraitViews();
            return PartialView("_AllPortraitsPartial", p);
        }

        [Authorize(Roles = "manager,artist,admin")]
        [HttpGet]
        public ActionResult Details(int idPortrait)
        {
            return View(_servicesManager.Portraits.GetPortraitViewById(idPortrait));
        }

        [HttpPost]
        public ActionResult CompleateOn(int idPortrait, string date)
        {
            DateTime d = DateTime.Parse(date);
            _dataManager.PhotosOnMonuments.CompleateOn(idPortrait, d);
            return View("Details", _servicesManager.Portraits.GetPortraitViewById(idPortrait));
        }
        //-------------------------------------------
        //private PortraitViewModel DBPortraitToView(int idPortrait)
        //{
        //    PortraitViewModel portrait = new PortraitViewModel();
        //    if (idPortrait > 0)
        //    {
        //        portrait = _servicesManager.Portraits.GetPortraitById(idPortrait);
        //    }
        //    return portrait;
        //}

    }
}
