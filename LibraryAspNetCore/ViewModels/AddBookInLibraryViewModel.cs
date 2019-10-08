using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryAspNetCore.ViewModels
{
    public class AddBookInLibraryViewModel
    {
        [Required(ErrorMessage = "Библиотека не выбрана")]
        public Guid LibraryId { get; set; }
        [Required(ErrorMessage = "Книга не выбрана")]
        public Guid BookId { get; set; }
        public string LibraryName { get; set; }
        [Range(1, 110, ErrorMessage = "Недопустимое колличество")]
        public int TotalQuantity { get; set; }
        //[Required(ErrorMessage = "Книги не выбраны")]
        //public List<BooksInLibraryViewModel> Books{ get; set; }
    }
}