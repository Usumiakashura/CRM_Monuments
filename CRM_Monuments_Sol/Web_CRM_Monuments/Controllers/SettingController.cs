using DataLayer;
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
using BuissnesLayer.Models;

namespace Web_CRM_Monuments.Controllers
{
    [Authorize(Roles = "admin")]
    public class SettingController : Controller
    {
        private DataManager _dataManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        //private readonly UserService _userService;

        public SettingController(DataManager dataManager, 
            UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager)

        {
            _dataManager = dataManager;
            _userManager = userManager;
            _signInManager = signInManager;
            //_userService = new UserService();
        }


        public ActionResult Settings()
        {
            return View();
        }

        //--------- Настройки пользователей --------------
        public async Task<ActionResult> AllUsers()
        {
            List<UserViewModel> users = new List<UserViewModel>();
            foreach (var u in await _dataManager.ApplicationUsersRepository.GetAllUsers())
            {
                UserViewModel user = new UserViewModel()
                {
                    Id = u.Id,
                    Email = u.Email,
                    Name = u.Name
                };
                foreach (var role in await _userManager.GetRolesAsync(await _userManager.FindByIdAsync(u.Id)))
                {
                    user.Role = role;
                }
                users.Add(user);
            }
            
            
            
            return View(users);
        }

        public IActionResult CreateUser() 
        {
            ViewData["Attention"] = "";
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_userManager.FindByEmailAsync(model.Email) != null)
                {
                    ViewData["Attention"] = "Пользователь с таким Email существует. Повторите попытку.";
                    return RedirectToAction("CreateUser", model);
                }
                
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email, Name = model.Name };
                var result = await _userManager.CreateAsync(user, model.Password);
                user = await _userManager.FindByEmailAsync(model.Email);
                await _userManager.AddToRoleAsync(user, model.Role);

                if (result.Succeeded)
                {
                    return RedirectToAction("AllUsers", "Setting");
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
            return View("CreateUser", model);
            
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
                        return RedirectToAction("AllUsers", "Setting");
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
            return RedirectToAction("AllUsers", "Setting");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteUser(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("AllUsers", "Setting");
        }



        //--------------------------------------------------
        //--------- Настройки типов портретов --------------
        [HttpGet]
        public ActionResult AllTypePortraits()
        {
            List<TypePortraitViewModel> types = new List<TypePortraitViewModel>();
            foreach (TypePortrait tp in _dataManager.TypesPortrait.GetAllTypesPortraits())
            {
                types.Add(new TypePortraitViewModel() { TypePortrait = tp });
            }
            return View(types);
        }
        [HttpPost]
        public ActionResult AllTypePortraits(List<TypePortraitViewModel> types)
        {
            foreach (TypePortraitViewModel tp in types)
            {
                if (tp.Deleted && tp.TypePortrait.Id > 0)
                    _dataManager.TypesPortrait.DeleteTypePortrait(tp.TypePortrait);
                else if (!tp.Deleted)
                    _dataManager.TypesPortrait.SaveTypePortrait(tp.TypePortrait);
            }
            return RedirectToAction("AllTypePortraits", types);
        }
        //--------------------------------------------------
        //--------- Настройки типов текстов ----------------
        [HttpGet]
        public ActionResult AllTypeTexts()
        {
            List<TypeTextViewModel> texts = new List<TypeTextViewModel>();
            foreach (TypeText tt in _dataManager.TypesTexts.GetAllTypesText())
            {
                texts.Add(new TypeTextViewModel() { TypeText = tt });
            }
            return View(texts);
        }

        [HttpPost]
        public ActionResult AllTypeTexts(List<TypeTextViewModel> texts)
        {
            foreach (TypeTextViewModel tt in texts)
            {
                if (tt.Deleted && tt.TypeText.Id > 0)
                    _dataManager.TypesTexts.DeleteTypeText(tt.TypeText);
                else if (!tt.Deleted)
                    _dataManager.TypesTexts.SaveTypeText(tt.TypeText);
            }
            return RedirectToAction("AllTypeTexts", texts);
        }

        
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
