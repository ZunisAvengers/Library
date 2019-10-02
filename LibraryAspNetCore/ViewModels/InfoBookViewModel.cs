using LibraryAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.ViewModels
{
    public class InfoBookViewModel
    {
        public Book Book { get; set; }
        public List<InfoBookInLibraryViewModel> Libraries { get; set; }
        public InfoBookViewModel(Book Book, List<BookInLibrary> bookInLibraries)
        {
            this.Book = Book;
            foreach (var item in bookInLibraries)
                Libraries.Add(new InfoBookInLibraryViewModel { Library = item.Library, CurrentQuantity = item.CurrentQuantity, TotalQuantity = item.TotalQuantity });
        }
    }
}
