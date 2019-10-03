using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.ViewModels
{
    public class AddBookInLibrariesViewModel
    {
        [Required(ErrorMessage = "Книга не выбрана")]
        public Guid BookId { get; set; }
        [Required(ErrorMessage = "Библиотеки не выбраны")]
        public List<BookInLibrariesIdViewModel> Libraries { get; set; }
    }
}
