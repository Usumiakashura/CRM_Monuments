using BuissnesLayer;
using DataLayer;
using DataLayer.ApplicationEntities;
using DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_CRM_Monuments.Controllers
{
    public class SettingController : Controller
    {
        private DataManager _dataManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;


        public SettingController(DataManager dataManager, 
            UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager)

        {
            _dataManager = dataManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [Authorize(Roles = "admin")]
        public ActionResult Settings()
        {
            

            return View();
        }

        public async Task<ActionResult> AllUsers()
        {
            return View(await _dataManager.ApplicationUsersRepository.GetAllUsers());
        }

        public ActionResult AllTypePortraits()
        {

            return View();
        }

        [HttpGet]
        public ActionResult AllTypeTexts()
        {
            List<TypeText> texts = new List<TypeText>();
            foreach (TypeText tt in _dataManager.TypesTexts.GetAllTypesText())
            {
                texts.Add(tt);
            }
            return View(texts);
        }
        [HttpPost]
        public ActionResult AllTypeTexts(List<TypeText> texts)
        {
            foreach (TypeText tt in texts)
            {
                _dataManager.TypesTexts.SaveTypeText(tt);
            }
            foreach (TypeText tt in _dataManager.TypesTexts.GetAllTypesText())
            {
                if (texts.Where(x => x.Id == tt.Id).Count() == 0)
                {
                    _dataManager.TypesTexts.DeleteTypeText(tt);
                }
            }
            return RedirectToAction("AllTypeTexts", texts);
        }

        public ActionResult AllMaterialsMedallions()
        {

            return View();
        }

        public ActionResult AllShapesMedallions()
        {

            return View();
        }

        public ActionResult AllColorsMedallions()
        {

            return View();
        }

    }
}
