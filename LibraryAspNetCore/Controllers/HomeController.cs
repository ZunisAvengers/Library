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
        private readonly ApplicationContext _context;
        public HomeController(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<InfoBookViewModel> info = new List<InfoBookViewModel>();
            foreach (var item in await _context.Books.ToListAsync())
                info.Add(new InfoBookViewModel(item, await _context.BooksInLibraries.Where(bl => bl.Book == item).ToListAsync()));
            return View(info);
            //return View(await _context.Books.ToListAsync());
        }
        public async Task<IActionResult> Info(Guid id)
        {
            Book book = await _context.Books
                    .Include(b => b.Author)
                    .Include(b => b.Subject)
                    .Include(b => b.PublishingHouse)
                    .FirstOrDefaultAsync(b => b.Id == id);
            if (book != null)
            {
                List<BookInLibrary> bookInLibraries = await _context.BooksInLibraries.Where(bl => bl.Book == book).ToListAsync();
                return View(new InfoBookViewModel(book, bookInLibraries));
            }
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
