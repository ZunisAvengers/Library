using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryAspNetCore.Models;
using Microsoft.EntityFrameworkCore;
using LibraryAspNetCore.ViewModels;

namespace LibraryAspNetCore.Controllers
{

    public class HomeController : Controller
    {
        private readonly ApplicationContext db;
        public HomeController(ApplicationContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }
        public async Task<IActionResult> List()
        {
            List<InfoBookViewModel> info = new List<InfoBookViewModel>();
            foreach(var item in await db.Books.ToListAsync())
                info.Add(new InfoBookViewModel(item, await db.BooksInLibraries.Where(bl => bl.Book == item).ToListAsync()));
            return View(info);
        }
        public async Task<IActionResult> Info(Guid id)
        {
            Book book = await db.Books
                    .Include(b => b.Author)
                    .Include(b => b.Subject)
                    .Include(b => b.PublishingHouse)
                    .FirstOrDefaultAsync(b => b.Id == id);
            if (book != null)
            {
                List<BookInLibrary> bookInLibraries = await db.BooksInLibraries.Where(bl => bl.Book == book).ToListAsync();
                return View(new InfoBookViewModel(book, bookInLibraries));
            }
            return RedirectToAction("List");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
