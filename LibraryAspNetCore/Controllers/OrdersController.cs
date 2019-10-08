﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryAspNetCore.Models;
using Microsoft.EntityFrameworkCore;
using LibraryAspNetCore.ViewModels;

namespace LibraryAspNetCore.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationContext _context;
        public OrdersController(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() =>
            View(_context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetailse)
                .Where(o => o.User.Login == User.Identity.Name)
                .ToListAsync());
        public async Task<IActionResult> Info(Guid id)
        {
            Order order = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetailse)
                .Where(o => o.User.Login == User.Identity.Name)
                .FirstOrDefaultAsync(o => o.Id == id);
            if (order != null && order.User.Login == User.Identity.Name) View(order);
            return RedirectToAction("Index");
        }
    }
}