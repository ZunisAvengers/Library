using System;

namespace LibraryAspNetCore.Controllers
{
    public class BooksInLibraryViewModel
    {
        public Guid BookId { get; set; }
        public int TotalQuantity { get; set; }
        public int CurrentQuantity { get; set; }
    }
}