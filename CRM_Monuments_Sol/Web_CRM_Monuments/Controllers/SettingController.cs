using BuissnesLayer;
using DataLayer;
using DataLayer.ApplicationEntities;
using DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_CRM_Monuments.Models;

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

        //--------- Настройки пользователей --------------
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> AllUsers() => View(await _dataManager.ApplicationUsersRepository.GetAllUsers());
        
        [Authorize(Roles = "admin")]
        public IActionResult CreateUser() => View();

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email, Name = model.Name };
                var result = await _userManager.CreateAsync(user, model.Password);
                user = await _userManager.FindByEmailAsync(model.Email);
                await _userManager.AddToRoleAsync(user, model.Role);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return RedirectToAction("AllUsers", "Setting");
        }

        public async Task<IActionResult> EditUser(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            UserViewModel model = new UserViewModel { Id = user.Id, Email = user.Email, Name = user.Name };
            foreach (var role in await _userManager.GetRolesAsync(user))
            {
                model.Role = role;
            }
            return RedirectToAction("EditUser", model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    user.Email = model.Email;
                    user.UserName = model.Email;
                    user.Name = model.Name;

                    var result = await _userManager.UpdateAsync(user);
                    user = await _userManager.FindByEmailAsync(model.Email);
                    await _userManager.RemoveFromRolesAsync(user, await _userManager.GetRolesAsync(user));
                    await _userManager.AddToRoleAsync(user, model.Role);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> DeleteUser(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("Index");
        }



        //--------------------------------------------------
        //--------- Настройки типов портретов --------------
        [Authorize(Roles = "admin")]
        public ActionResult AllTypePortraits()
        {

            return View();
        }

        [Authorize(Roles = "admin")]
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

        [Authorize(Roles = "admin")]
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

        [Authorize(Roles = "admin")]
        public ActionResult AllMaterialsMedallions()
        {

            return View();
        }

        [Authorize(Roles = "admin")]
        public ActionResult AllShapesMedallions()
        {

            return View();
        }

        [Authorize(Roles = "admin")]
        public ActionResult AllColorsMedallions()
        {

            return View();
        }

    }
}
