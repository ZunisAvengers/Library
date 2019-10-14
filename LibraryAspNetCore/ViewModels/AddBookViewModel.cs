using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.ViewModels
{
    public class AddBookViewModel
    {
        [Required(ErrorMessage = "Не указано Название")]
        public string Name { get; set; }
        public Guid? AuthorsId { get; set; }
        public string AuthorsName { get; set; }
        [Required(ErrorMessage = "Не указано Издательство")]
        public Guid PublishingHouseId { get; set; }
        [Required(ErrorMessage = "Не указана Дата Публикации")]
        public DateTime YearOfPublishing { get; set; }
        [Required(ErrorMessage = "Не указан Жанр")]
        public Guid SubjectId { get; set; }
        [Required(ErrorMessage = "Не указан ISBN")]
        //[RegularExpression(@"(?=.{17}$)97(?:8|9)([ -])\d{1,5}\1\d{1,7}\1\d{1,6}\1\d$", ErrorMessage = "Номер ISBN должен соответствовать стандарту ISBN-13")]
        public string ISBN { get; set; }
        public IFormFile Image { get; set; }
    }
}
