﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryAspNetCore.Models;
using Microsoft.EntityFrameworkCore;
using LibraryAspNetCore.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace LibraryAspNetCore.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly ApplicationContext _context;
        public OrdersController(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() =>
            View(await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetailse)
                .Where(o => o.User.Login == User.Identity.Name && o.DeliveredInLibrary == false)
                .ToListAsync());
        public async Task<IActionResult> Story() => 
            View(await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetailse)
                .Where(o => o.User.Login == User.Identity.Name && o.DeliveredInLibrary == true)
                .ToListAsync());
        public async Task<IActionResult> Info(Guid id)
        {
            Order order = await _context.Orders
                .Include(o => o.Library)
                .Include(o => o.User)
                .Include(o => o.OrderDetailse)
                .Where(o => o.User.Login == User.Identity.Name)
                .FirstOrDefaultAsync(o => o.Id == id);
            if (order != null && order.User.Login == User.Identity.Name) 
            {
                List<OrderDetailse> orderDetailses = await _context.OrderDetailses
                    .Include(o => o.Book)
                        .ThenInclude(bl => bl.Book)
                    .Where(o => o.Order == order)
                    .ToListAsync();
                List<Book> books = new List<Book>();
                foreach (var od in orderDetailses)
                {
                    Book book = await _context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == od.Book.Book.Id);
                    books.Add(book);
                }
                return View(new OrderViewModel { Books = books, Order = order });
            }
            return RedirectToAction("Index");
        }
    }
}