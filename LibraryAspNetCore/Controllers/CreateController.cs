using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAspNetCore.Models;
using LibraryAspNetCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryAspNetCore.Controllers
{
    [Authorize(Roles = "Admin, Moder")]
    public class CreateController : Controller
    {
        private readonly ApplicationContext db;
        public CreateController(ApplicationContext db)
        {
            this.db = db;
        }
        public IActionResult Index() => View();
        [HttpGet]
        public async Task<IActionResult> AddBook()
        {
            ViewBag.Authors = new SelectList(await db.Authors.ToListAsync(), "Id", "Name");
            ViewBag.Subjects = new SelectList(await db.Subjects.ToListAsync(), "Id", "Name");
            ViewBag.PublishingHouses = new SelectList(await db.PublishingHouses.ToListAsync(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBook(AddBookViewModel model)
        {

            return View();
        }
    }
}
