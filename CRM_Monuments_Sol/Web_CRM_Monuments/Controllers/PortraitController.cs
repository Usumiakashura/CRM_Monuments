﻿using BuissnesLayer;
using Microsoft.AspNetCore.Http;
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
            var p = _servicesManager.Portraits.GetAllPortraits();
            return PartialView("_AllPortraitsPartial", p);
        }

        [HttpGet]
        public ActionResult Details(int idPortrait)
        {
            
            return View(DBPortraitToView(idPortrait));
        }

        [HttpPost]
        public ActionResult CompleateOn(int idPortrait, string date)
        {
            DateTime d = DateTime.Parse(date);
            _dataManager.PhotosOnMonuments.CompleateOn(idPortrait, d);
            PortraitViewModel portrait = DBPortraitToView(idPortrait);
            return RedirectToAction("Details", idPortrait);
            //return RedirectToAction("Index", "Home");
        }
        //-------------------------------------------
        private PortraitViewModel DBPortraitToView(int idPortrait)
        {
            PortraitViewModel portrait = new PortraitViewModel();
            if (idPortrait > 0)
            {
                portrait = _servicesManager.Portraits.GetPortraitById(idPortrait);
            }
            return portrait;
        }

    }
}