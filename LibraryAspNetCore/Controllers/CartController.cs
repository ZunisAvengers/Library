using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAspNetCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAspNetCore.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ApplicationContext _context;
        public CartController(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            User user = await _context.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
            List<Cart> list = await _context.Carts
                .Include(c => c.User)
                .Include(c => c.BookInLibrary)
                    .ThenInclude(bl => bl.Library)
                .Include(c => c.BookInLibrary)
                    .ThenInclude(bl => bl.Book)
                        .ThenInclude(bb => bb.Author)
                .Where(c => c.User == user)
                .ToListAsync();
            ViewBag.Error = "";
            ViewBag.Library = list.Any() ? list[0].BookInLibrary.Library.Name : "";
            return View(list);
        }        
        [HttpPost]
        public async Task<IActionResult> Index(DateTime date)
        {
            User user = await _context.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
            if (date >= DateTime.Today)
            {
                List<Cart> carts = await _context.Carts
                    .Include(c => c.User)
                    .Include(c => c.BookInLibrary)
                        .ThenInclude(bl => bl.Library)
                    .Where(c => c.User == user)
                    .ToListAsync();
                if (carts != null && carts.Count > 0)
                {
                    Order order = new Order
                    {
                        DateGet = date,
                        DateOrder = DateTime.Today,
                        User = user,
                        Library = carts[0].BookInLibrary.Library
                    };
                    foreach (var item in carts)
                    {
                        _context.OrderDetailses.Add(new OrderDetailse
                        {
                            Book = item.BookInLibrary,
                            Order = order
                        });
                        _context.Carts.Remove(await _context.Carts.FirstOrDefaultAsync(c => c == item));
                    }
                    _context.Orders.Add(order);
                    await _context.SaveChangesAsync();
                    ViewBag.Error = "";
                    return RedirectToAction("Info", "Orders", order.Id);
                }
            }
            ViewBag.Error = "Дата выдачи заказа должна быть не позже сегоднешнего дня";
            List<Cart> list = await _context.Carts
                .Include(c => c.User)
                .Include(c => c.BookInLibrary)
                    .ThenInclude(bl => bl.Library)
                .Include(c => c.BookInLibrary)
                    .ThenInclude(bl => bl.Book)
                        .ThenInclude(bb => bb.Author)
                .Where(c => c.User == user)
                .ToListAsync();
            ViewBag.Library = list.Any() ? list[0].BookInLibrary.Library.Name : "";
            return View(list);
        }
        public async Task<IActionResult> AddBookInCart(Guid id)
        {
            BookInLibrary bookInLibrary = await _context.BooksInLibraries
                .Include(bl => bl.Library)
                .FirstOrDefaultAsync(b => b.Id == id);
            User user = await _context.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
            List <Cart> carts = await _context.Carts
                .Include(c => c.User)
                .Include(c => c.BookInLibrary)
                    .ThenInclude(bl => bl.Library)
                .Where(c => c.User == user)
                .ToListAsync();
            if (bookInLibrary != null && user != null && bookInLibrary.CurrentQuantity > 0)
            {
                if (carts == null || carts.Count == 0 || carts[0].BookInLibrary.Library == bookInLibrary.Library)
                {
                    _context.Carts.Add(new Cart
                    {
                        User = user,
                        BookInLibrary = bookInLibrary
                    });
                    bookInLibrary.CurrentQuantity--;
                    _context.BooksInLibraries.Update(bookInLibrary);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> RemoveBookInCart(Guid id)
        {
            Cart bookInCart = await _context.Carts
                .Include(c => c.User)
                .Include(c => c.BookInLibrary)
                .FirstOrDefaultAsync(c => c.Id == id);
            User user = await _context.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
            if (bookInCart != null && user != null && bookInCart.User == user)
            {
                BookInLibrary bookInLibrary = await _context.BooksInLibraries.FirstOrDefaultAsync(b => b == bookInCart.BookInLibrary);
                bookInLibrary.CurrentQuantity++;
                _context.BooksInLibraries.Update(bookInLibrary);
                _context.Carts.Remove(bookInCart);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}