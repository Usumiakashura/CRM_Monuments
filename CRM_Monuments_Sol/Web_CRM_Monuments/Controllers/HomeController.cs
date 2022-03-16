using BuissnesLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.IO;
using System.Threading.Tasks;
using Web_CRM_Monuments.Models;
using Web_CRM_Monuments.Services;

namespace Web_CRM_Monuments.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebHostEnvironment _hostingEnvironment;
        private DataManager _dataManager;
        private ServicesManager _servicesManager;

        public HomeController(ILogger<HomeController> logger, DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _dataManager = dataManager;
            _servicesManager = new ServicesManager(_dataManager);
            _hostingEnvironment = hostingEnvironment;
        }

        [Authorize(Roles = "manager,artist,engraver,admin")]
        public IActionResult Index()
        {
            //var c = _dataManager.Contracts.GetAllContracts();

            if (User.IsInRole("manager")/* || User.IsInRole("admin")*/)
            {
                ViewBag.ModelP = _dataManager.Contracts.GetAllContracts();
                ViewBag.Partial = "../Contract/_AllContractsPartial.cshtml";
                ViewBag.Slider = new HtmlString("" +
                    "<div><input type = \"button\" value =\"Договора\" class=\"full\" id=\"AllContracts\" style=\"height: 50px; margin-right: 10px;\" /></div>" +
                    "<div><input type = \"button\" value=\"Портреты\" class=\"full\" id=\"AllPortraits\" style=\"height: 50px; margin-right: 10px;\" /></div>" +
                    "<div><input type = \"button\" value=\"Медальоны\" class=\"full\" id=\"AllMedallions\" style=\"height: 50px; margin-right: 10px;\" /></div>" +
                    "<div><input type = \"button\" value=\"Текста\" class=\"full\" id=\"AllTexts\" style=\"height: 50px; margin-right: 10px;\" /></div>");
            }
            else if (User.IsInRole("artist"))
            {
                ViewBag.ModelP = _servicesManager.Portraits.GetAllPortraitViews();
                ViewBag.Partial = "../Portrait/_AllPortraitsPartial.cshtml";
                ViewBag.Slider = new HtmlString("" +
                    "<div><input type = \"button\" value = \"Портреты\" class=\"full\" id=\"AllPortraits\" style=\"height: 50px; margin-right: 10px;\" /></div>");
            }
            else if (User.IsInRole("engraver"))
            {
                ViewBag.ModelP = _servicesManager.Texts.GetAllTextViews();
                ViewBag.Partial = "../Text/_AllTextsPartial.cshtml";
                ViewBag.Slider = new HtmlString("" +
                    "<div><input type = \"button\" value=\"Текста\" class=\"full\" id=\"AllTexts\" style=\"height: 50px; margin-right: 10px;\" /></div>");
            }
            if (User.IsInRole("admin"))
                return RedirectToAction("Settings", "Setting");

            return View();
        }

        [Authorize(Roles = "admin")]
        public IActionResult Settings()
        {
            return View();
        }


        //[HttpGet]
        //public ActionResult AllContracts()
        //{
        //    var c = _dataManager.Contracts.GetAllContracts();
        //    return PartialView("_AllContractsPartial", c);
        //}
        //[HttpGet]
        //public ActionResult AllPortraits()
        //{
        //    var p = _servicesManager.Portraits.GetAllPortraits();
        //    return PartialView("_AllPortraitsPartial", p);
        //}
        //[HttpGet]
        //public ActionResult AllMedallions()
        //{
        //    var m = _dataManager.PhotosOnMonuments.GetAllMedallions();
        //    return PartialView("_AllMedallionsPartial", m);
        //}
        //[HttpGet]
        //public ActionResult AllTexts()
        //{

        //    return PartialView("_AllTextsPartial");
        //}


        

    }
}
