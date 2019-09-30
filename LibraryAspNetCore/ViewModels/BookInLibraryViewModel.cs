using LibraryAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.ViewModels
{
    public class BookInLibraryViewModel
    {
        public Library Library { get; set; }
        public int TotalQuantity { get; set; }
        public int CurrentQuantity { get; set; }
    }
}
