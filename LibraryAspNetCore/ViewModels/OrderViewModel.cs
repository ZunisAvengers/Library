using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAspNetCore.Models;

namespace LibraryAspNetCore.ViewModels
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public List<Book> Books { get; set; }
    }
}
