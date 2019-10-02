using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.Models
{
    public class Library
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        //public int TotalUniqueBooks { get; set; }
        public List<BookInLibrary> BookInLibrares { get; set; }
        public Library()
        {
            BookInLibrares = new List<BookInLibrary>();
        }
    }
}
