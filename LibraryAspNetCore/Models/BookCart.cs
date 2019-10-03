using System;

namespace LibraryAspNetCore.Models
{
    public class BookCart
    {
        public Guid Id { get; set; }
        public string BookCartId { get; set; }
        public BookInLibrary Book { get; set; }
    }
}