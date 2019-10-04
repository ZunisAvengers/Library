using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryAspNetCore.ViewModels
{
    public class AddBooksInLibraryViewModel
    {
        [Required(ErrorMessage = "Библиотека не выбрана")]
        public Guid LibraryId { get; set; }
        [Required(ErrorMessage = "Книги не выбраны")]
        public List<BooksInLibraryViewModel> Books{ get; set; }
    }
}