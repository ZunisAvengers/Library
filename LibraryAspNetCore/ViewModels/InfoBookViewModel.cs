using LibraryAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.ViewModels
{
    public class InfoBookViewModel
    {
        public Book Book { get; set; }
        public List<InfoBookInLibraryViewModel> Libraries { get; set; }
    }
    public class InfoBookInLibraryViewModel
    {
        public Library Library { get; set; }
        public Guid BookinLibraryId { get; set; }
        public int TotalQuantity { get; set; }
        public int CurrentQuantity { get; set; }
        
    }
}
