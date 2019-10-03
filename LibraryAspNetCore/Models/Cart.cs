using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LibraryAspNetCore.Models
{
    public class Cart
    {
        private readonly ApplicationContext _context;
        public Cart(ApplicationContext context)
        {
            _context = context;
        }
        public string BookCartId { get; set; }
        public Guid LibraryId;
        public List<BookCart> BookCarts { get; set; }
        public static Cart GetCart(IServiceProvider serviceProvider)
        {
            ISession session = serviceProvider.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
            string bookCartId = session.GetString("ChatId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", bookCartId);
            return new Cart(serviceProvider.GetService<ApplicationContext>()) { BookCartId = bookCartId };
        }
        public async void AddCart(BookInLibrary book)
        {
            _context.BookCarts.Add(new BookCart
            {
                BookCartId = BookCartId,
                Book = book
            });
            await _context.SaveChangesAsync();
        }
        public async void RemoveCart(Guid id)
        {
            _context.BookCarts.Remove(await _context.BookCarts.FirstOrDefaultAsync(bc => bc.Id == id));
            await _context.SaveChangesAsync();
            
        }
        public async Task<List<BookCart>> ListBookCart() => await _context.BookCarts
                .Where(bc => bc.BookCartId == BookCartId)
                .Include(bc => bc.Book)
                .ToListAsync();
    }
}
