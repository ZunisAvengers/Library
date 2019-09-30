using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAspNetCore.Models;
//using LibraryAspNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryAspNetCore.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationContext db;
        public AccountController(ApplicationContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Login() => View();
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                else ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Register() => View();
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Login == model.Login || u.EMail == model.Email);
                if (user == null)
                {
                    user = new User {FirstName = model.FirstName, LastName = model.LastName, Login = model.Login, EMail = model.Email, Password = model.Password, DateOfBirth = DateTime.Now };
                    Role userRole = await db.Roles.FirstOrDefaultAsync(r => r.Name == "User");
                    if (userRole != null)
                    {
                        user.RoleId = userRole.Id;
                        user.Role = userRole;
                    }
                    db.Users.Add(user);
                    await db.SaveChangesAsync();
                    await Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                if (user != null) ModelState.AddModelError("", "Пользователь с таким именем или почтой уже существует");
                else ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> UserInfo(Guid? id)
        //{
        //    User user = await db.Users.Include(x => x.Role).FirstOrDefaultAsync(u => u.Id == id);
        //    if (user != null)
        //        return View(user);
        //    return RedirectToAction("list");
        //}
        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> UpRole(Guid id)
        //{
        //    User user = await db.Users.Include(x => x.Role).FirstOrDefaultAsync(u => u.Id == id);
        //    if (user != null && user.Role.Name == "User")
        //    {
        //        Role role = await db.Roles.FirstOrDefaultAsync(r => r.Name == "Moder");
        //        user.Role = role;
        //        user.RoleId = role.Id;
        //        db.Users.Update(user);
        //        await db.SaveChangesAsync();
        //    }
        //    return RedirectToAction("UserInfo", "Account", user.Id);
        //}
        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> DownRole(Guid id)
        //{
        //    User user = await db.Users.Include(x => x.Role).FirstOrDefaultAsync(u => u.Id == id);
        //    if (user != null && user.Role.Name == "Moder")
        //    {
        //        Role role = await db.Roles.FirstOrDefaultAsync(r => r.Name == "User");
        //        user.Role = role;
        //        user.RoleId = role.Id;
        //        db.Users.Update(user);
        //        await db.SaveChangesAsync();
        //    }
        //    return RedirectToAction("UserInfo", "Account", user.Id);
        //}
        public async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
