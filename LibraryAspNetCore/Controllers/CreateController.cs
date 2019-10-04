using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LibraryAspNetCore.Models;
using LibraryAspNetCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LibraryAspNetCore.Controllers
{
    [Authorize(Roles = "Admin, Moder")]
    public class CreateController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IHostingEnvironment _appEnvironment;
        public CreateController(ApplicationContext context, IHostingEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }
        public IActionResult Index() => View();
        [HttpGet]
        public async Task<IActionResult> AddBook()
        {
            ViewBag.Authors = new SelectList(await _context.Authors.ToListAsync(), "Id", "Name");
            ViewBag.Subjects = new SelectList(await _context.Subjects.ToListAsync(), "Id", "Name");
            ViewBag.PublishingHouses = new SelectList(await _context.PublishingHouses.ToListAsync(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBook(AddBookViewModel model)
        {
            if (ModelState.IsValid)
            {
                Book book = await _context.Books.FirstOrDefaultAsync(b => b.Name == model.Name || b.ISBN == model.ISBN);
                if (book == null)
                {
                    string path = "images/noneBook",
                        type = "image/jpg";
                    if (model.Image != null)
                    {
                        path = "images/" + model.Name.Replace(' ', '_');
                        type = model.Image.ContentType;
                        using (FileStream fs = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                            await model.Image.CopyToAsync(fs);
                    }
                    _context.Books.Add(book = new Book
                    {
                        Name = model.Name,
                        Author = model.AuthorsId == Guid.Empty ? await AddAuthor(model.AuthorsName) : await _context.Authors.FirstOrDefaultAsync(a => a.Id == model.AuthorsId),
                        PublishingHouse = await _context.PublishingHouses.FirstOrDefaultAsync(a => a.Id == model.PublishingHouseId),
                        Subject = await _context.Subjects.FirstOrDefaultAsync(a => a.Id == model.SubjectId),
                        ISBN = model.ISBN,
                        YearOfPublishing = model.YearOfPublishing,
                        ImagePath = path,
                        ImageType = type
                    });
                    await _context.SaveChangesAsync();
                    ViewBag.Massage = "Книга успешно добавлена";
                    return RedirectToAction("Info", "Home", book.Id);
                }
            }
            ViewBag.Authors = new SelectList(await _context.Authors.ToListAsync(), "Id", "Name");
            ViewBag.Subjects = new SelectList(await _context.Subjects.ToListAsync(), "Id", "Name");
            ViewBag.PublishingHouses = new SelectList(await _context.PublishingHouses.ToListAsync(), "Id", "Name");
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> EditBook(Guid id)
        {
            Book book = await _context.Books
                    .Include(b => b.Author)
                    .Include(b => b.Subject)
                    .Include(b => b.PublishingHouse)
                    .FirstOrDefaultAsync(b => b.Id == id);
            if (book != null)
            {
                ViewBag.Authors = new SelectList(await _context.Authors.ToListAsync(), "Id", "Name");
                ViewBag.Subjects = new SelectList(await _context.Subjects.ToListAsync(), "Id", "Name");
                ViewBag.PublishingHouses = new SelectList(await _context.PublishingHouses.ToListAsync(), "Id", "Name");
                return View(book);
            }
            //ViewBag.Massage = "Такой книги не существует";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditBook(AddBookViewModel model)
        {
            if (ModelState.IsValid)
            {
                Book book = await _context.Books.FirstOrDefaultAsync(b => b.Name == model.Name || b.ISBN == model.ISBN);
                if (book != null)
                {
                    string path = "images/noneBook",
                        type = "image/jpg";
                    if (model.Image != null)
                    {
                        path = "images/" + model.Name.Replace(' ', '_');
                        type = model.Image.ContentType;
                        using (FileStream fs = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                            await model.Image.CopyToAsync(fs);
                    }
                    _context.Books.Update(book = new Book
                    {
                        Name = model.Name,
                        Author = model.AuthorsId == Guid.Empty ? await AddAuthor(model.AuthorsName) : await _context.Authors.FirstOrDefaultAsync(a => a.Id == model.AuthorsId),
                        PublishingHouse = await _context.PublishingHouses.FirstOrDefaultAsync(a => a.Id == model.PublishingHouseId),
                        Subject = await _context.Subjects.FirstOrDefaultAsync(a => a.Id == model.SubjectId),
                        ISBN = model.ISBN,
                        YearOfPublishing = model.YearOfPublishing,
                        ImagePath = path,
                        ImageType = type
                    });
                    await _context.SaveChangesAsync();
                    //ViewBag.Massage = "Книга успешно добавлена";
                    return RedirectToAction("Info", "Home", book.Id);
                }
            }
            ViewBag.Authors = new SelectList(await _context.Authors.ToListAsync(), "Id", "Name");
            ViewBag.Subjects = new SelectList(await _context.Subjects.ToListAsync(), "Id", "Name");
            ViewBag.PublishingHouses = new SelectList(await _context.PublishingHouses.ToListAsync(), "Id", "Name");
            return View(model);
        }
        [NonAction]
        public async Task<Author> AddAuthor(string authorName)
        {
            Author author = await _context.Authors.FirstOrDefaultAsync(a => a.Name == authorName);
            if (author == null)
            {
                _context.Authors.Add(author = new Author { Name = authorName });
                await _context.SaveChangesAsync();
            }
            return author;
        }
        [HttpGet]
        public IActionResult AddLibrary()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddLibrary(AddLibraryViewModel model)
        {
            if (ModelState.IsValid)
            {
                Library library= await _context.Libraries.FirstOrDefaultAsync(l => l.Name == model.Name || l.Address == model.Address);
                if (library == null)
                {
                    _context.Libraries.Add(library = new Library 
                    {
                        Name = model.Name,
                        Phone = model.Phone,
                        Address = model.Address,
                    });
                    await _context.SaveChangesAsync();
                    //ViewBag.Massage = "Библиотека успешно добавлена";
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> EditLibrary(Guid id)
        {
            Library library = await _context.Libraries.FirstOrDefaultAsync(l => l.Id == id);
            if (library != null) return View(library);
            ViewBag.Massage = "Такая библиотека не найдена ";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditLibrary(AddLibraryViewModel model)
        {
            if (ModelState.IsValid)
            {
                Library library = await _context.Libraries.FirstOrDefaultAsync(l => l.Name == model.Name || l.Address == model.Address);
                if (library != null)
                {
                    _context.Libraries.Update(library = new Library
                    {
                        Name = model.Name,
                        Phone = model.Phone,
                        Address = model.Address,
                    });
                    await _context.SaveChangesAsync();
                    //ViewBag.Massage = "Библиотека успешно изменена";
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
        //[HttpGet]
        //public async Task<IActionResult> AddBookInLibraries()
        //{
        //    ViewBag.Books = new SelectList(await _context.Books.ToListAsync(), "Id", "Name");
        //    ViewBag.Libraries = new SelectList(await _context.Libraries.ToListAsync(), "Id", "Name");
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddBookInLibraries(AddBookInLibrariesViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Book book = await _context.Books.FirstOrDefaultAsync(b => b.Id == model.BookId);
        //        if (book != null && model.Libraries.Count > 0)
        //        {
        //            foreach (var library in model.Libraries)
        //            {
        //                _context.BooksInLibraries.Add(new BookInLibrary
        //                {
        //                    Book = book,
        //                    Library = await _context.Libraries.FirstOrDefaultAsync(l => l.Id == library.LibraryId),
        //                    TotalQuantity = library.TotalQuantity,
        //                    //CurrentQuantity = library.CurrentQuantity
        //                });
        //            }
        //            await _context.SaveChangesAsync();
        //        }
        //    }
        //    ViewBag.Authors = new SelectList(await _context.Authors.ToListAsync(), "Id", "Name");
        //    ViewBag.Subjects = new SelectList(await _context.Subjects.ToListAsync(), "Id", "Name");
        //    return View(model);
        //}
        //[HttpGet]
        //public async Task<IActionResult> AddBooksInLibrary()
        //{
        //    ViewBag.Authors = new SelectList(await _context.Books.ToListAsync(), "Id", "Name");
        //    ViewBag.Subjects = new SelectList(await _context.Libraries.ToListAsync(), "Id", "Name");
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddBooksInLibrary(AddBooksInLibraryViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Library library = await _context.Libraries.FirstOrDefaultAsync(l => l.Id == model.LibraryId);
        //        if (library != null && model.Books.Count > 0)
        //        {
        //            foreach (var book in model.Books)
        //            {
        //                _context.BooksInLibraries.Add(new BookInLibrary
        //                {
        //                    Book = await _context.Books.FirstOrDefaultAsync(b => b.Id == book.BookId),
        //                    Library = library,
        //                    TotalQuantity = book.TotalQuantity,
        //                    //CurrentQuantity = book.CurrentQuantity
        //                });
        //            }
        //            await _context.SaveChangesAsync();
        //        }
        //    }
        //    ViewBag.Authors = new SelectList(await _context.Authors.ToListAsync(), "Id", "Name");
        //    ViewBag.Subjects = new SelectList(await _context.Subjects.ToListAsync(), "Id", "Name");
        //    return View(model);
        //}
    }
}
