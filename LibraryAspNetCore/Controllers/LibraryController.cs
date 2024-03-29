﻿using System;
using System.Threading.Tasks;
using LibraryAspNetCore.Models;
using LibraryAspNetCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LibraryAspNetCore.Controllers
{
    [Authorize(Roles = "Admin, Moder")]
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
        public async Task<IActionResult> AddBookInLibrary(Guid id)
        {
            Library library = await _context.Libraries.FirstOrDefaultAsync(l => l.Id == id);
            if (library != null)
            {
                ViewBag.Books = new SelectList(await _context.Books.ToListAsync(), "Id", "Name");
                return View(new AddBookInLibraryViewModel { LibraryId = library.Id, LibraryName = library.Name });
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddBookInLibrary(AddBookInLibraryViewModel model)
        {
            if (ModelState.IsValid)
            {
                BookInLibrary book = await _context.BooksInLibraries
                    .Include(b => b.Library)
                    .Include(b => b.Book)
                    .FirstOrDefaultAsync(b => b.Book.Id == model.BookId && b.Library.Id == model.LibraryId);
                if (book == null)
                {
                    Library library = await _context.Libraries.FirstOrDefaultAsync(l => l.Id == model.LibraryId);
                    _context.BooksInLibraries.Add(new BookInLibrary
                    {
                        Library = library,
                        Book = await _context.Books.FirstOrDefaultAsync(b => b.Id == model.BookId),
                        TotalQuantity = model.TotalQuantity,
                        CurrentQuantity = model.TotalQuantity
                    });
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Info", library.Id);
                }
                ModelState.AddModelError("", "Вы пытаетесь добавить книгу, которая уже есть в данной библиотеки");
            }
            ViewBag.Books = new SelectList(await _context.Books.ToListAsync(), "Id", "Name");
            return View(model);
        }
    }
}
