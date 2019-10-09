using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public BookInLibrary BookInLibrary { get; set; }
    }
}
