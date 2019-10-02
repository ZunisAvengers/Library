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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryAspNetCore.Controllers
{
    [Authorize(Roles = "Admin, Moder")]
    public class CreateController : Controller
    {
        private readonly ApplicationContext db;
        private readonly IHostingEnvironment appEnvironment;
        public CreateController(ApplicationContext db, IHostingEnvironment appEnvironment)
        {
            this.db = db;
            this.appEnvironment = appEnvironment;
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
            if (ModelState.IsValid)
            {
                Book book = await db.Books.FirstOrDefaultAsync(b => b.Name == model.Name || b.ISBN == model.ISBN);
                if (book == null)
                {
                    string path = "images/noneBook",
                        type = "image/jpg";
                    if (model.Image != null)
                    {
                        path = "images/" + model.Name.Replace(' ', '_');
                        type = model.Image.ContentType;
                        using (FileStream fs = new FileStream(appEnvironment.WebRootPath + path, FileMode.Create))
                            await model.Image.CopyToAsync(fs);
                    }
                    db.Books.Add(book = new Book
                    {
                        Name = model.Name,
                        Author = model.AuthorsId == Guid.Empty ? await AddAuthor(model.AuthorsName) : await db.Authors.FirstOrDefaultAsync(a => a.Id == model.AuthorsId),
                        PublishingHouse = await db.PublishingHouses.FirstOrDefaultAsync(a => a.Id == model.PublishingHouseId),
                        Subject = await db.Subjects.FirstOrDefaultAsync(a => a.Id == model.SubjectId),
                        ISBN = model.ISBN,
                        YearOfPublishing = model.YearOfPublishing,
                        ImagePath = path,
                        ImageType = type
                    });
                    await db.SaveChangesAsync();
                    ViewBag.Massage = "Книга успешно добавлена";
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Authors = new SelectList(await db.Authors.ToListAsync(), "Id", "Name");
            ViewBag.Subjects = new SelectList(await db.Subjects.ToListAsync(), "Id", "Name");
            ViewBag.PublishingHouses = new SelectList(await db.PublishingHouses.ToListAsync(), "Id", "Name");
            return View(model);
        }
        [NonAction]
        public async Task<Author> AddAuthor(string authorName)
        {
            Author author = await db.Authors.FirstOrDefaultAsync(a => a.Name == authorName);
            if (author == null)
            {
                db.Authors.Add(author = new Author { Name = authorName });
                await db.SaveChangesAsync();
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
                Library library= await db.Libraries.FirstOrDefaultAsync(l => l.Name == model.Name || l.Address == model.Address);
                if (library == null)
                {
                    db.Libraries.Add(library = new Library 
                    {
                        Name = model.Name,
                        Phone = model.Phone,
                        Address = model.Address,
                    });
                    await db.SaveChangesAsync();
                    ViewBag.Massage = "Библиотека успешно добавлена";
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> AddBookInLibraries()
        {
            ViewBag.Authors = new SelectList(await db.Books.ToListAsync(), "Id", "Name");
            ViewBag.Subjects = new SelectList(await db.Libraries.ToListAsync(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBookInLibraries(AddBooksInLibraryViewModel model)
        {
            if (ModelState.IsValid)
            {
                Book book = await db.Books.FirstOrDefaultAsync(b => b.Id == model.BookId);
                if (book != null && model.Libraries.Count > 0)
                {
                    foreach (var library in model.Libraries)
                    {
                        db.BooksInLibraries.Add(new BookInLibrary
                        {
                            Book = book,
                            Library = await db.Libraries.FirstOrDefaultAsync(l => l.Id == library.LibraryId),
                            TotalQuantity = library.TotalQuantity,
                            CurrentQuantity = library.CurrentQuantity
                        });
                    }
                    await db.SaveChangesAsync();
                }
            }
            ViewBag.Authors = new SelectList(await db.Authors.ToListAsync(), "Id", "Name");
            ViewBag.Subjects = new SelectList(await db.Subjects.ToListAsync(), "Id", "Name");
            return View(model);
        }
    }
}
