using System;
using System.Collections.Generic;

namespace LibraryAspNetCore.Controllers
{
    public class AddBooksInLibraryViewModel
    {
        public Guid LibraryId { get; set; }
        public List<BooksInLibraryViewModel> Books{ get; set; }
    }
}