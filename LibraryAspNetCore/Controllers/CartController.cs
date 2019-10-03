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
        [HttpGet]
        public async Task<IActionResult> Order()
        {
            _cart.BookCarts = await _cart.ListBookCart();
            if (_cart.BookCarts.Count > 0 && _cart.BookCarts != null) return View();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Order(Order order)
        {
            if (ModelState.IsValid)
            {
                order.DateOrder = DateTime.Now;
                order.User = await _context.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
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
            return View(order);
        }
    }
}