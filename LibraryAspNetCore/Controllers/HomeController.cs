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
            //IQueryable<Book> books = _context.Books.Include(b => b.Author).Include(b => b.Subject);
            //List<InfoBookViewModel> info = new List<InfoBookViewModel>();
            //foreach (var item in books)
            //    info.Add(new InfoBookViewModel(item, 
            //        await _context.BooksInLibraries
            //        .Include(b => b.Book)
            //            .ThenInclude(bl => bl.Author)
            //        .Include(b => b.Book)
            //            .ThenInclude(bl => bl.Subject)
            //        .Include(b => b.Book)
            //            .ThenInclude(bl => bl.PublishingHouse)
            //        .Include(b => b.Library)
            //        .Where(bl => bl.Book == item)
            //        .ToListAsync()));
            //return View(info);

            return View(await _context.Books
                .Include(b => b.Author)
                .Include(b => b.PublishingHouse)
                .Include(b => b.Subject)
                .ToListAsync());
        }
        public async Task<IActionResult> Info(Guid id)
        {
            Book book = await _context.Books
                    .Include(b => b.Author)
                    .Include(b => b.Subject)
                    .Include(b => b.PublishingHouse)
                    .Include(b => b.BookInLibrares)
                    .FirstOrDefaultAsync(b => b.Id == id);
            if (book != null)
            {
                List<BookInLibrary> books = await _context.BooksInLibraries.Include(bl => bl.Library).Where(bl => bl.Book == book).ToListAsync();
                List<InfoBookInLibraryViewModel> infoBooks = new List<InfoBookInLibraryViewModel>();
                foreach (var item in books)
                    infoBooks.Add(new InfoBookInLibraryViewModel
                    {
                        Library = await _context.Libraries.Include(l => l.BookInLibrares).FirstOrDefaultAsync(l => l.Id == item.Library.Id),
                        TotalQuantity = item.TotalQuantity,
                        CurrentQuantity = item.CurrentQuantity
                    });
                return View(new InfoBookViewModel { Book = book, Libraries = infoBooks});
                
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
