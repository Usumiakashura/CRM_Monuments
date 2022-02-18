using BuissnesLayer;
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
        //public ContractViewModel contractViewModel;

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
            ViewBag.TypeTexts = _dataManager.SelectPointsRepository.GetAllTypesText();// new List<string>() { "Углубленный", "Литье", "Caggiatti", "На табличке", "На медальоне", "Станочный", "Фрейзерный" };
            ViewBag.TypePortraits = _dataManager.SelectPointsRepository.GetAllTypesPortraits();// new List<string>() { "Ручной", "Станочный" };
            ViewBag.MedallionMaterials = _dataManager.SelectPointsRepository.GetAllMedallionsMaterials();// new List<string>() { "Керамогранит", "Керамика (фарфор)", "Триплекс", "Однослойное стекло", "Металлокерамика", "Табличка из нерж.стали" };
            ViewBag.ShapesMedallions = _dataManager.SelectPointsRepository.GetAllShapesMedallions();// new List<string>() { "Овальная", "Прямоугольная", "Арка" };
            ViewBag.ColorsMedallions = _dataManager.SelectPointsRepository.GetAllColorsMedallions();// new List<string>() { "Цветной", "Черно-белый" };

            ContractViewModel contractViewModel = new ContractViewModel();

            if (idContract == 0)
            {
                contractViewModel.Contract = new Contract()
                {
                    Id = -1,
                    DateOfConclusion = DateTime.Today,
                    DeadLine = DateTime.Today.AddDays(90),
                    NumYear = (DateTime.Today.Year.ToString()).Substring(2),
                    Place = "ДО",
                    Number = _dataManager.Contracts.NewNumber()
                };
                contractViewModel.Contract.Customers.Add(new Customer());
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
            _servicesManager.Contracts.SaveViewModelToDB(contractViewModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteContract(int idContract)
        {
            _dataManager.Contracts.DeleteContract(_dataManager.Contracts.GetContractById(idContract));

            return RedirectToAction("Index");
        }

        //public int EditCounter(int newCounter)
        //{
        //    contractViewModel.Counter = newCounter;
        //    return contractViewModel.Counter;
        //}

    }
}
