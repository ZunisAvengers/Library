using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.Models
{
    public class BookInLibrary
    {
        public Guid Id { get; set; }
        public Book Book { get; set; }
        public Library Library{ get; set; }
        public int TotalQuantity { get; set; }
        public int CurrentQuantity { get; set; }
    }
}
