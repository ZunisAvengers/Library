using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.ViewModels
{
    public class AddLibraryViewModel
    {
        [Required(ErrorMessage = "Не указано")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указан Адрес")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Не указан Номер телефона")]
        [RegularExpression(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$", ErrorMessage = "Номер указан не верно")]
        public string Phone { get; set; }
        //public int TotalUniqueBooks { get; set; }
    }
}
