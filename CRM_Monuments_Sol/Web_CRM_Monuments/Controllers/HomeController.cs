﻿using BuissnesLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Web_CRM_Monuments.Models;
using Web_CRM_Monuments.Services;

namespace Web_CRM_Monuments.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataManager _dataManager;
        private ServicesManager _servicesManager;

        public HomeController(ILogger<HomeController> logger, DataManager dataManager)
        {
            _logger = logger;
            _dataManager = dataManager;
            _servicesManager = new ServicesManager(_dataManager);
        }

        public IActionResult Index()
        {
            var c = _dataManager.Contracts.GetAllContracts();
            return View(c);
        }

        [HttpGet]
        public ActionResult CreateContract(int idContract)
        {
            ViewBag.TypeText = new List<string>() { "Углубленный", "Литье", "Caggiati" };
            //ViewBag.TypePortrait = new List<string>() { "Ручной", "Станочный" };
            //ViewBag.MedallionMaterial = new List<string>() { "Материал 1", "Материал 2" };

            ContractViewModel contractViewModel = new ContractViewModel();

            if (idContract == 0)
            {
                contractViewModel.Contract = new Contract()
                {
                    DateOfConclusion = DateTime.Today,
                    DeadLine = DateTime.Today.AddDays(90),
                    NumYear = (DateTime.Today.Year.ToString()).Substring(2),
                    Place = "ДО",
                    Number = _dataManager.Contracts.NewNumber()
                };
            }
            else
            {
                Contract c = _dataManager.Contracts.GetContractById(idContract);
                contractViewModel = _servicesManager.Contracts.ModelDBToModelView(c);
            }

            return View(contractViewModel);
        }

        

        [HttpPost]
        public ActionResult CreateContract(ContractViewModel contractViewModel)
        {
            //if (ModelState.IsValid)
            //    return Content($"{person.Name} - {person.Email}");
            //else
            //    return View(contractViewModel);

            Contract c = _servicesManager.Contracts.ModelViewToModelDB(contractViewModel);
            _dataManager.Contracts.SaveContract(c);

            return RedirectToAction("Index");
        }


        //[HttpGet]
        //public ActionResult EditContract(int idContract)
        //{

        //    Contract c = _dataManager.Contracts.GetContractById(idContract);
        //    ContractViewModel cvm = _servicesManager.Contracts.ModelDBToModelView(c);
            
        //    return RedirectToAction("CreateContract", cvm);
        //}

        //[HttpPost]
        //public ActionResult EditContract(Contract contract)
        //{



        //    return RedirectToAction("Index");
        //}




        //-----------------------------------------------------------------

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}


    }
}
