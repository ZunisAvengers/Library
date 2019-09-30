﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указано Имя")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Не указано Имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Не указана Фамилия")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }

    
}
