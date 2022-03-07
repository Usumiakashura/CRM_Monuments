using BuissnesLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Hosting;
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

        public IActionResult Index()
        {
            var c = _dataManager.Contracts.GetAllContracts();

            return View(c);
        }

        [HttpGet]
        public ActionResult AllContracts()
        {
            var c = _dataManager.Contracts.GetAllContracts();
            return PartialView("_AllContractsPartial", c);
        }
        //[HttpGet]
        //public ActionResult AllPortraits()
        //{
        //    var p = _servicesManager.Portraits.GetAllPortraits();
        //    return PartialView("_AllPortraitsPartial", p);
        //}
        [HttpGet]
        public ActionResult AllMedallions()
        {
            //var c = _dataManager.Contracts.GetAllContracts();
            return PartialView("_AllMedallionsPartial");
        }
        [HttpGet]
        public ActionResult AllTexts()
        {

            return PartialView("_AllTextsPartial");
        }


        //[HttpGet]
        //public ActionResult CreateEditContract(int idContract)
        //{
        //    ViewBag.TypeTexts = _dataManager.SelectPointsRepository.GetAllTypesText();// new List<string>() { "Углубленный", "Литье", "Caggiatti", "На табличке", "На медальоне", "Станочный", "Фрейзерный" };
        //    ViewBag.TypePortraits = _dataManager.SelectPointsRepository.GetAllTypesPortraits();// new List<string>() { "Ручной", "Станочный" };
        //    ViewBag.MedallionMaterials = _dataManager.SelectPointsRepository.GetAllMedallionsMaterials();// new List<string>() { "Керамогранит", "Керамика (фарфор)", "Триплекс", "Однослойное стекло", "Металлокерамика", "Табличка из нерж.стали" };
        //    ViewBag.ShapesMedallions = _dataManager.SelectPointsRepository.GetAllShapesMedallions();// new List<string>() { "Овальная", "Прямоугольная", "Арка" };
        //    ViewBag.ColorsMedallions = _dataManager.SelectPointsRepository.GetAllColorsMedallions();// new List<string>() { "Цветной", "Черно-белый" };

        //    ContractViewModel contractViewModel;

        //    if (idContract == 0)
        //    {
        //        contractViewModel = new ContractViewModel();
        //        contractViewModel.Contract.Number = _dataManager.Contracts.NewNumber();
        //    }
        //    else
        //    {
        //        Contract c = _dataManager.Contracts.GetContractById(idContract);
        //        contractViewModel = _servicesManager.Contracts.ModelDBToModelView(c);
        //    }

        //    return View(contractViewModel);
        //}

        //[HttpPost]
        //public async Task<ActionResult> CreateEditContract(ContractViewModel contractViewModel)
        //{
        //    string contractNumber = $"{contractViewModel.Contract.NumYear}-{contractViewModel.Contract.Place}-{contractViewModel.Contract.Number}";
        //    string uniqueFileName = null;

        //    if (contractViewModel.Photos != null)
        //    {
        //        for (int i = 0; i < contractViewModel.Photos.Count; i++)
        //        {
        //            if (contractViewModel.Photos[i].Image != null)
        //            {
        //                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, @"images\photos-on-monuments\" + contractNumber);
        //                DirectoryInfo dirInfo = new DirectoryInfo(uploadsFolder);
        //                if (!dirInfo.Exists)
        //                    dirInfo.Create();

        //                uniqueFileName = Guid.NewGuid().ToString() + $"_{contractNumber}_{contractViewModel.Photos[i].Image.FileName}";
        //                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

        //                using (var fileStream = new FileStream(filePath, FileMode.Create))
        //                {
        //                    await contractViewModel.Photos[i].Image.CopyToAsync(fileStream);
        //                }
        //                if (contractViewModel.Photos[i].PhotoKey.Contains('P'))
        //                {
        //                    contractViewModel.Portraits[contractViewModel.Photos[i].PhotoKey]
        //                        .PhotoPath = @"/Images/photos-on-monuments/" + contractNumber + "/" + uniqueFileName;
        //                    contractViewModel.Portraits[contractViewModel.Photos[i].PhotoKey].PhotoName = uniqueFileName;
        //                }
        //                else if (contractViewModel.Photos[i].PhotoKey.Contains('M'))
        //                {
        //                    contractViewModel.Medallions[contractViewModel.Photos[i].PhotoKey]
        //                        .PhotoPath = @"/Images/photos-on-monuments/" + contractNumber + "/" + uniqueFileName;
        //                    contractViewModel.Medallions[contractViewModel.Photos[i].PhotoKey].PhotoName = uniqueFileName;
        //                }
        //            }

        //        }
        //    }

        //    _servicesManager.Contracts.SaveViewModelToDB(contractViewModel);

        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public ActionResult DeleteContract(int idContract)
        //{
        //    _dataManager.Contracts.DeleteContract(_dataManager.Contracts.GetContractById(idContract));

        //    return RedirectToAction("Index");
        //}



    }
}
