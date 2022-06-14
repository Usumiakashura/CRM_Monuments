using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BuissnesLayer.Models;
using BuissnesLayer.Services;

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


        [Authorize(Roles = "manager,admin")]
        [HttpGet]
        public async Task<ActionResult> CreateEditContract(int idContract)
        {

            await FillViewBags();


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

            return RedirectToAction("Index", "Home");
        }

        //--------------------------------

        private async Task FillViewBags()
        {
            ViewBag.TypesText = _dataManager.TypesTexts.GetAllTypesText();
            string typesTextHTML = "";
            foreach (TypeText tt in ViewBag.TypesText)
                typesTextHTML += $"<option value=\"{tt.Id}\">{tt.Name}</option>";
            ViewBag.TypesTextsHTML = new HtmlString(typesTextHTML);

            ViewBag.TypesPortrait = _dataManager.TypesPortrait.GetAllTypesPortraits();
            string typesPortraitHTML = "";
            foreach (var tp in ViewBag.TypesPortrait)
                typesPortraitHTML += $"<option value=\"{tp.Id}\">{tp.Name}</option>";
            ViewBag.TypesPortraitHTML = new HtmlString(typesPortraitHTML);

            ViewBag.MedallionMaterials = _dataManager.MedallionMaterials.GetAllMedallionsMaterials();
            string medallionMaterialHTML = "";
            foreach (var mm in ViewBag.MedallionMaterials)
                medallionMaterialHTML += $"<option value=\"{mm.Id}\">{mm.Name}</option>";
            ViewBag.MedallionMaterialsHTML = new HtmlString(medallionMaterialHTML);

            ViewBag.ShapesMedallions = _dataManager.ShapeMedallions.GetAllShapesMedallions();
            string shapeMedallionHTML = "";
            foreach (var sm in ViewBag.ShapesMedallions)
                shapeMedallionHTML += $"<option value=\"{sm.Id}\">{sm.Name}</option>";
            ViewBag.ShapesMedallionsHTML = new HtmlString(shapeMedallionHTML);

            ViewBag.Artists = await _dataManager.ApplicationUsersRepository.GetAllArtists();
            string artistHTML = "";
            foreach (ApplicationUser au in ViewBag.Artists)
                artistHTML += $"<option value=\"{au.Id}\">{au.Name}</option>";
            ViewBag.ArtistsHTML = new HtmlString(artistHTML);

            ViewBag.Engravers = await _dataManager.ApplicationUsersRepository.GetAllEngravers();
            string engraverHTML = "";
            foreach (ApplicationUser au in ViewBag.Engravers)
                engraverHTML += $"<option value=\"{au.Id}\">{au.Name}</option>";
            ViewBag.EngraversHTML = new HtmlString(engraverHTML);
        }

    }
}
