using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAspNetCore.Models;
using LibraryAspNetCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAspNetCore.Controllers
{
    [Authorize(Roles = "Admin, Moder")]
    public class ObserverController : Controller
    {
        private readonly ApplicationContext _context;
        public ObserverController(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders
                .Include(o => o.User)
                .Where(o => o.DeliveredInLibrary == false)
                .ToListAsync());
        }
        public async Task<IActionResult> Story()
        {
            return View(await _context.Orders
                .Include(o => o.User)
                .Where(o => o.DeliveredInLibrary == true)
                .ToListAsync());
        }
        public async Task<IActionResult> Info(Guid id)
        {
            Order order = await _context.Orders
                .Include(o => o.Library)
                .Include(o => o.User)
                .Include(o => o.OrderDetailse)
                    .ThenInclude(od => od.Book)
                        .ThenInclude(bl => bl.Book)
                .FirstOrDefaultAsync(o => o.Id == id);
            if (order != null) 
            {
                List<OrderDetailse> orderDetailses = await _context.OrderDetailses.Where(o => o.Order == order).ToListAsync();
                List<Book> books = new List<Book>();
                foreach(var od in orderDetailses)
                {
                    books.Add(await _context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b == od.Book.Book));
                }
                return View(new OrderViewModel {Books = books, Order = order });
            }
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> Close(Guid id)
        {
            Order order = await _context.Orders
                .Include(o => o.OrderDetailse)
                .FirstOrDefaultAsync(o => o.Id == id);
            if (order.DeliveredInLibrary) ViewBag.Message = "Заказ уже закрыт";
            else if (order != null)
            {
                order.DeliveredInLibrary = true;
                if(!order.IsGet) order.IsGet = true;
                _context.Orders.Update(order);
                List<OrderDetailse> orderDetailse = await _context.OrderDetailses.Include(od => od.Book).Where(od => od.Order == order).ToListAsync();
                foreach(var item in orderDetailse)
                {
                    item.Book.CurrentQuantity++;
                    _context.BooksInLibraries.Update(item.Book);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Info", id);
            }
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> SetBook(Guid id)
        {
            Order order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (order != null)
            {
                if (order.IsGet) ViewBag.Message = "Заказ уже выдан";
                order.IsGet = true;
                _context.Orders.Update(order);
                await _context.SaveChangesAsync();
                return RedirectToAction("Info", id);
            }
            return RedirectToAction("Index");
        }
    }
}