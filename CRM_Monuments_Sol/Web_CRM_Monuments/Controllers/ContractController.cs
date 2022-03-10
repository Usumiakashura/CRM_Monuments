using BuissnesLayer;
using DataLayer.ApplicationEntities;
using DataLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web_CRM_Monuments.Models;
using Web_CRM_Monuments.Services;

namespace Web_CRM_Monuments.Controllers
{
    public class ContractController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private DataManager _dataManager;
        private ServicesManager _servicesManager;

        public ContractController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            _dataManager = dataManager;
            _servicesManager = new ServicesManager(_dataManager);
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public ActionResult AllContracts()
        {
            var c = _dataManager.Contracts.GetAllContracts();
            return PartialView("_AllContractsPartial", c);
        }

        [HttpGet]
        public async Task<ActionResult> CreateEditContract(int idContract)
        {
            string typesTextHTML = "";
            foreach (var tt in _dataManager.SelectPointsRepository.GetAllTypesText())
                typesTextHTML += $"<option value=\"{tt}\">{tt}</option>";
            ViewBag.TypesTextsHTML = new HtmlString(typesTextHTML);
            
            string typesPortraitHTML = "";
            foreach (var tp in _dataManager.SelectPointsRepository.GetAllTypesPortraits())
                typesPortraitHTML += $"<option value=\"{tp}\">{tp}</option>";
            ViewBag.TypesPortraitHTML = new HtmlString(typesPortraitHTML);

            string medallionMaterialHTML = "";
            foreach (var mm in _dataManager.SelectPointsRepository.GetAllMedallionsMaterials())
                medallionMaterialHTML += $"<option value=\"{mm}\">{mm}</option>";
            ViewBag.MedallionMaterialsHTML = new HtmlString(medallionMaterialHTML);

            string shapeMedallionHTML = "";
            foreach (var sm in _dataManager.SelectPointsRepository.GetAllShapesMedallions())
                shapeMedallionHTML += $"<option value=\"{sm}\">{sm}</option>";
            ViewBag.ShapesMedallionsHTML = new HtmlString(shapeMedallionHTML);

            string colorMedallionHTML = "";
            foreach (var cm in _dataManager.SelectPointsRepository.GetAllColorsMedallions())
                colorMedallionHTML += $"<option value=\"{cm}\">{cm}</option>";
            ViewBag.ColorsMedallionsHTML = new HtmlString(colorMedallionHTML);

            string artistHTML = "";
            foreach (ApplicationUser au in await _dataManager.ApplicationUsersRepository.GetAllArtists())
                artistHTML += $"<option value=\"{au.Name}\">{au.Name}</option>";
            ViewBag.ArtistsHTML = new HtmlString(artistHTML);

            ContractViewModel contractViewModel;

            if (idContract == 0)
            {
                contractViewModel = new ContractViewModel();
                contractViewModel.Contract.Number = _dataManager.Contracts.NewNumber();
            }
            else
            {
                Contract c = _dataManager.Contracts.GetContractById(idContract);
                contractViewModel = _servicesManager.Contracts.ModelDBToModelView(c);
            }

            return View(contractViewModel);
        }

        [HttpPost]
        public async Task<ActionResult> CreateEditContract(ContractViewModel contractViewModel)
        {
            string contractNumber = $"{contractViewModel.Contract.NumYear}-{contractViewModel.Contract.Place}-{contractViewModel.Contract.Number}";
            string uniqueFileName = null;

            if (contractViewModel.Photos != null)
            {
                for (int i = 0; i < contractViewModel.Photos.Count; i++)
                {
                    if (contractViewModel.Photos[i].Image != null)
                    {
                        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, @"images\photos-on-monuments\" + contractNumber);
                        DirectoryInfo dirInfo = new DirectoryInfo(uploadsFolder);
                        if (!dirInfo.Exists)
                            dirInfo.Create();

                        uniqueFileName = Guid.NewGuid().ToString() + $"_{contractNumber}_{contractViewModel.Photos[i].Image.FileName}";
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await contractViewModel.Photos[i].Image.CopyToAsync(fileStream);
                        }
                        if (contractViewModel.Photos[i].PhotoKey.Contains('P'))
                        {
                            contractViewModel.Portraits[contractViewModel.Photos[i].PhotoKey]
                                .PhotoPath = @"/Images/photos-on-monuments/" + contractNumber + "/" + uniqueFileName;
                            contractViewModel.Portraits[contractViewModel.Photos[i].PhotoKey].PhotoName = uniqueFileName;
                        }
                        else if (contractViewModel.Photos[i].PhotoKey.Contains('M'))
                        {
                            contractViewModel.Medallions[contractViewModel.Photos[i].PhotoKey]
                                .PhotoPath = @"/Images/photos-on-monuments/" + contractNumber + "/" + uniqueFileName;
                            contractViewModel.Medallions[contractViewModel.Photos[i].PhotoKey].PhotoName = uniqueFileName;
                        }
                    }

                }
            }

            _servicesManager.Contracts.SaveViewModelToDB(contractViewModel);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult DeleteContract(int idContract)
        {
            _dataManager.Contracts.DeleteContract(_dataManager.Contracts.GetContractById(idContract));

            return RedirectToAction("Index");
        }

        

    }
}
