using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.Models
{
    public class OrderDetailse
    {
        public Guid Id { get; set; }
        public BookInLibrary Book { get; set; }
        public Order Order { get; set; }
    }
}
