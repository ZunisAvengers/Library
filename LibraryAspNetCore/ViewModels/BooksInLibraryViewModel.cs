using System;

namespace LibraryAspNetCore.ViewModels
{
    public class BooksInLibraryViewModel
    {
        public Guid BookId { get; set; }
        public int TotalQuantity { get; set; }
    }
}