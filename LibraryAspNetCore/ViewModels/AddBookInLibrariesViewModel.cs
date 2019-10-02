using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.ViewModels
{
    public class AddBookInLibrariesViewModel
    {
        public Guid BookId { get; set; }
        public List<BookInLibrariesIdViewModel> Libraries { get; set; }
    }
}
