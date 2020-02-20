﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using MyOwnApp.Models;
using MyOwnApp.ViewModels;
using Newtonsoft.Json;

namespace MyOwnApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly EFContext _context;
        private readonly IProducers _producers;
        public AccountController(IProducers producers, UserManager<User> userManager, SignInManager<User> signInManager,
        EFContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _producers = producers;
        }
        [HttpGet]
        public IActionResult AccountAction()
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);
            }
            AccountActionModel obj = new AccountActionModel();
            obj.GetProducers = _producers.GetProducers.ToList();
            obj.ProducersCount = _producers.GetProducers.Count();
            RegisterViewModel obj2 = new RegisterViewModel();           
            LoginViewModel obj3 = new LoginViewModel();
            obj.LoginViewModel = obj3;
            obj.RegisterViewModel = obj2;
            return View(obj);
        }
        //[HttpGet]
        //public IActionResult Register()
        //{
        //    RegisterViewModel obj = new RegisterViewModel();
        //    obj.GetProducers = _producers.GetProducers.ToList();
        //    obj.ProducersCount = _producers.GetProducers.Count();
        //    return View(obj);
        //}
        //[HttpGet]
        //public IActionResult Login()
        //{
        //    LoginViewModel obj = new LoginViewModel();
        //    obj.GetProducers = _producers.GetProducers.ToList();
        //    obj.ProducersCount = _producers.GetProducers.Count();
        //    return View(obj);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            AccountActionModel obj = new AccountActionModel();
            obj.GetProducers = _producers.GetProducers.ToList();
            obj.ProducersCount = _producers.GetProducers.Count();
            obj.RegisterViewModel = new RegisterViewModel();
            obj.LoginViewModel = new LoginViewModel();
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            var user = _context.Users.FirstOrDefault(t => t.Email == model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "User not exist");
                return View(obj);
            }
            var result = _signInManager.PasswordSignInAsync(user, model.Password, false, false).Result;
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Incorrect password");
                return View(obj);
            }
            await _signInManager.SignInAsync(user, isPersistent: false);
            
            await Authenticate(user.Email);
            var userInfo = new UserInfo()
            {
                UserId = user.Id,
                Email = user.Email
            };
            HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(userInfo));
            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            AccountActionModel obj = new AccountActionModel();
            if (!ModelState.IsValid)
            {
                obj.GetProducers = _producers.GetProducers.ToList();
                obj.ProducersCount = _producers.GetProducers.Count();
                obj.RegisterViewModel = new RegisterViewModel();
                obj.LoginViewModel=new LoginViewModel();
                return View(obj);
            }
            UserProfile userProfile = new UserProfile()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = /*model.Address*/ "35372 Privutna 12",
                RegisterDate = DateTime.Now,
                CountOfLogins = 0,
                Image = ""
            };
            User user = new User()
            {
                PhoneNumber = model.Phone,
                Email = model.Email,
                UserName = model.Email,
                UserProfile = userProfile
            };
            var res = await _userManager.CreateAsync(user, model.Password);
            res = _userManager.AddToRoleAsync(user, "User").Result;
            if (res.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in res.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }
            }

            obj.GetProducers = _producers.GetProducers.ToList();
            obj.ProducersCount = _producers.GetProducers.Count();
            obj.RegisterViewModel = new RegisterViewModel();
            obj.LoginViewModel = new LoginViewModel();
            return View(obj);
        }
        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        public IActionResult AccessDenied()
        {
            return RedirectToAction("AccountGet", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("AccountGet", "Account");
        }
    }
}