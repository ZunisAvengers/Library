using System;
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
            ViewBag.Authors = new SelectList(await _context.Authors.OrderBy(n => n.Name).ToListAsync(), "Id", "Name", "Выберете Автора");
            ViewBag.Subjects = new SelectList(await _context.Subjects.OrderBy(n => n.Name).ToListAsync(), "Id", "Name", "Выберете Жанр");
            ViewBag.PublishingHouses = new SelectList(await _context.PublishingHouses.OrderBy(n => n.Name).ToListAsync(), "Id", "Name", "Выберете Издательство");
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
                    string path = book.ImagePath,
                        type = book.ImageType;
                    if (model.Image != null)
                    {
                        path = "images/" + model.Name.Replace(' ', '_');
                        type = model.Image.ContentType;
                        using (FileStream fs = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                            await model.Image.CopyToAsync(fs);
                    }
                    book.Name = model.Name;
                    book.Author = model.AuthorsId == Guid.Empty ? await AddAuthor(model.AuthorsName) : await _context.Authors.FirstOrDefaultAsync(a => a.Id == model.AuthorsId);
                    book.PublishingHouse = await _context.PublishingHouses.FirstOrDefaultAsync(a => a.Id == model.PublishingHouseId);
                    book.Subject = await _context.Subjects.FirstOrDefaultAsync(a => a.Id == model.SubjectId);
                    book.ISBN = model.ISBN;
                    book.YearOfPublishing = model.YearOfPublishing;
                    book.ImagePath = path;
                    book.ImageType = type;
                    _context.Books.Update(book);
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
            //ViewBag.Massage = "Такая библиотека не найдена ";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditLibrary(Library model)
        {
            if (ModelState.IsValid)
            {
                Library library = await _context.Libraries.FirstOrDefaultAsync(l => l.Id == model.Id);
                if (library != null)
                {
                    library.Name = model.Name;
                    library.Phone = model.Phone;
                    library.Address = model.Address;
                    _context.Libraries.Update(library);
                    await _context.SaveChangesAsync();
                    //ViewBag.Massage = "Библиотека успешно изменена";
                    return RedirectToAction("Info","Library", library.Id);
                }
            }
            return View(model);
        }        
        [HttpGet]
        public IActionResult Author()
        {
            return View(_context.Authors.OrderBy(n => n.Name).ToList());
        }
        [HttpPost]
        public async Task<IActionResult> Author(string name)
        {
            Author author= await _context.Authors.FirstOrDefaultAsync(c => c.Name == name);
            if (author == null)
            {
                author = new Author { Name = name };
                _context.Authors.Add(author);
                await _context.SaveChangesAsync();
            }
            return View(_context.Authors.OrderBy(n => n.Name).ToList());
        }
        [HttpGet]
        public async Task<IActionResult> EditAuthor(Guid id)
        {
            Author author = await _context.Authors.FirstOrDefaultAsync(c => c.Id == id);
            if (author != null) return View(author);
            return RedirectToAction("Author");
        }
        [HttpPost]
        public async Task<IActionResult> EditAuthor(Author author)
        {
            Author _author = await _context.Authors.FirstOrDefaultAsync(c => c.Name == author.Name);
            if (_author == null)
            {
                _context.Authors.Update(author);
                await _context.SaveChangesAsync();
                return RedirectToAction("Author");
            }
            ModelState.AddModelError("", "Такой автор уже существует");
            return View(author);
        }
        [HttpGet]
        public IActionResult Subject()
        {
            return View(_context.Subjects.OrderBy(n => n.Name).ToList());
        }
        [HttpPost]
        public async Task<IActionResult> Subject(string name)
        {
            Subject Subject = await _context.Subjects.FirstOrDefaultAsync(c => c.Name == name);
            if (Subject == null)
            {
                Subject = new Subject { Name = name };
                _context.Subjects.Add(Subject);
                await _context.SaveChangesAsync();
            }
            return View(_context.Subjects.OrderBy(n => n.Name).ToList());
        }
        [HttpGet]
        public async Task<IActionResult> EditSubject(Guid id)
        {
            Subject Subject = await _context.Subjects.FirstOrDefaultAsync(c => c.Id == id);
            if (Subject != null) return View(Subject);
            return RedirectToAction("Subject");
        }
        [HttpPost]
        public async Task<IActionResult> EditSubject(Subject Subject)
        {
            Subject _Subject = await _context.Subjects.FirstOrDefaultAsync(c => c.Name == Subject.Name);
            if (_Subject == null)
            {
                _context.Subjects.Update(Subject);
                await _context.SaveChangesAsync();
                return RedirectToAction("Subject");
            }
            ModelState.AddModelError("", "Такой жанр уже существует");
            return View(Subject);
        }
        [HttpGet]
        public IActionResult PublihingHouse()
        {
            return View(_context.PublishingHouses.OrderBy(n => n.Name).ToList());
        }
        [HttpPost]
        public async Task<IActionResult> PublihingHouse(string name)
        {
            PublishingHouse PublishingHouse= await _context.PublishingHouses.FirstOrDefaultAsync(c => c.Name == name);
            if (PublishingHouse== null)
            {
                PublishingHouse= new PublishingHouse{ Name = name };
                _context.PublishingHouses.Add(PublishingHouse);
                await _context.SaveChangesAsync();
            }
            return View(_context.PublishingHouses.OrderBy(n => n.Name).ToList());
        }
        [HttpGet]
        public async Task<IActionResult> EditPublihingHouse(Guid id)
        {
            PublishingHouse PublishingHouse= await _context.PublishingHouses.FirstOrDefaultAsync(c => c.Id == id);
            if (PublishingHouse!= null) return View(PublishingHouse);
            return RedirectToAction("PublihingHouse");
        }
        [HttpPost]
        public async Task<IActionResult> EditPublihingHouse(PublishingHouse PublishingHouse)
        {
            PublishingHouse _PublishingHouse = await _context.PublishingHouses.FirstOrDefaultAsync(c => c.Name == PublishingHouse.Name);
            if (PublishingHouse == null)
            {
                _context.PublishingHouses.Update(PublishingHouse);
                await _context.SaveChangesAsync();
                return RedirectToAction("PublihingHouse");
            }
            ModelState.AddModelError("", "Такое издательство уже существует");
            return View(PublishingHouse);
        }
    }
}