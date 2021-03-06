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
    public class TextController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataManager _dataManager;
        private ServicesManager _servicesManager;

        public TextController(ILogger<HomeController> logger, DataManager dataManager)
        {
            _logger = logger;
            _dataManager = dataManager;
            _servicesManager = new ServicesManager(_dataManager);
        }

        [HttpGet]
        public ActionResult AllTexts()
        {
            var t = _servicesManager.Texts.GetAllTextViews();
            return PartialView("_AllTextsPartial", t);
        }

        [Authorize(Roles = "manager,engraver,admin")]
        [HttpGet]
        public ActionResult Details(int idDeceaced, bool epitaph)
        {
            return View(_servicesManager.Texts.GetTextViewById(idDeceaced, epitaph));
        }

        [HttpPost]
        public ActionResult CompleateOn(int idDeceaced, bool epitaph, string date)
        {
            DateTime d = DateTime.Parse(date);
            if (epitaph)
                _dataManager.Epitaphs.CompleateOnTextEpitaph(idDeceaced, d);
            else
                _dataManager.TextsOnStella.CompleateOnTextName(idDeceaced, d);
            
            return View("Details", _servicesManager.Texts.GetTextViewById(idDeceaced, epitaph));
        }
        

    }
}
