using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.ViewModels
{
    public class AddBooksInLibraryViewModel
    {
        public Guid BookId { get; set; }
        public List<BookInLibraryIdViewModel> Libraries { get; set; }
    }
}
