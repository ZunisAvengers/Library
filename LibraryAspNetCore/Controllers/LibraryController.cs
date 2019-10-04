using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAspNetCore.Models;
using LibraryAspNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LibraryAspNetCore.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ApplicationContext _context;
        public LibraryController (ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Libraries.ToListAsync());
        }
        public async Task<IActionResult> Info(Guid id)
        {
            Library library = await _context.Libraries
                .Include(l => l.BookInLibrares)
                .FirstOrDefaultAsync(l => l.Id == id);
            if (library != null) return View(library);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> AddBooks(Guid id)
        {
            Library library = await _context.Libraries.FirstOrDefaultAsync(l => l.Id == id);
            if (library != null)
            {
                ViewBag.Books = new SelectList(await _context.Books.ToListAsync(), "Id", "Name");
                return View(library);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddBooks(AddBooksInLibraryViewModel model)
        {
            if (ModelState.IsValid && model.Books != null && model.Books.Count > 0)
            {
                Library library = await _context.Libraries.FirstOrDefaultAsync(l => l.Id == model.LibraryId);
                foreach (var book in model.Books)
                {
                    _context.BooksInLibraries.Add(new BookInLibrary
                    {
                        Library = library,
                        Book = await _context.Books.FirstOrDefaultAsync(l => l.Id == book.BookId),
                        TotalQuantity = book.TotalQuantity,
                        CurrentQuantity = book.TotalQuantity
                    });
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Info", "Library", library);
            }
            ViewBag.Books = new SelectList(await _context.Books.ToListAsync(), "Id", "Name");
            return View(model);
        }
    }
}