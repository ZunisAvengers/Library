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
            return View(await _context.Orders.ToListAsync());
        }
        public async Task<IActionResult> Info(Guid id)
        {
            Order order = await _context.Orders
                .Include(o => o.Library)
                .Include(o => o.OrderDetailse)
                    .ThenInclude(od => od.Book)
                        .ThenInclude(bl => bl.Book)
                .FirstOrDefaultAsync(o => o.Id == id);
            if (order != null) 
            {
                return View(order);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Close(Guid id)
        {
            Order order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (order != null)
            {
                if (order.Delivered) ViewBag.Message = "Заказ уже закрыт";
                order.Delivered = true;
                _context.Orders.Update(order);
                await _context.SaveChangesAsync();
                return RedirectToAction("Info", "Home", id);
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
                return RedirectToAction("Info", "Home", id);
            }
            return RedirectToAction("Index");
        }
    }
}