using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAspNetCore.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly Cart _cart;
        public CartController(ApplicationContext context, Cart cart)
        {
            _cart = cart;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //ViewBag.Library = await _context.Libraries.FirstOrDefaultAsync(l => l.Id == _cart.LibraryId);
            //List<BookInLibrary> books = new List<BookInLibrary>();
            //List<BookCart> carts = await _cart.GetBooks();
            //foreach (var book in carts) books.Add(await _context.BooksInLibraries.FirstOrDefaultAsync(b => b == book.Book));
            _cart.BookCarts = await _cart.GetBooks();
            return View(_cart);
        }       
        
        public async Task<IActionResult> Order(DateTime date)
        {
            if (ModelState.IsValid)
            {
                Order order = new Order();
                order.DateGet = date;
                order.DateOrder = DateTime.Now;
                order.User = await _context.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
                //order.Library= await _context.Libraries.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
                _cart.BookCarts = await _cart.GetBooks();
                foreach (var item in _cart.BookCarts)
                {
                    _context.OrderDetailses.Add(new OrderDetailse
                    {
                        Book = item.Book,
                        Order = order
                    });
                    _cart.RemoveCart(item.Id);
                }
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index");
        }
        
        public async void AddCart(Guid id)
        {
            BookInLibrary book = await _context.BooksInLibraries.FirstOrDefaultAsync(bl => bl.Id == id);
            if (book != null && book.CurrentQuantity > 0)
            {
                _cart.AddCart(book);
            }
            ViewBag.Massage = "Данной книги нет в наличии";
        }
        
        public void RemoveCart(Guid id)
        {
            _cart.RemoveCart(id);
        }
    }
}