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
        public IActionResult Index()
        {
            return View(_cart.ListBookCart());
        }       
        [HttpPost]
        public async Task<IActionResult> Index(DateTime date)
        {
            if (ModelState.IsValid)
            {
                Order order = new Order();
                order.DateGet = date;
                order.DateOrder = DateTime.Now;
                order.User = await _context.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
                //order.Library= await _context.Libraries.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
                _cart.BookCarts = await _cart.ListBookCart();
                foreach(var item in _cart.BookCarts)
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
            return View();
        }
        [HttpPost]
        public async void AddCart(Guid id)
        {
            BookInLibrary book = await _context.BooksInLibraries.FirstOrDefaultAsync(bl => bl.Id == id);
            if (book != null && book.CurrentQuantity > 0)
            {
                _cart.AddCart(book);
            }
            ViewBag.Massage = "Данной книги нет в наличии";
        }
        [HttpPost]
        public void RemoveCart(Guid id)
        {
            _cart.RemoveCart(id);
        }
    }
}