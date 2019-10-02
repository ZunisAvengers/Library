using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public List<OrderDetailse> OrderDetailse { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime DateGet { get; set; }
        public DateTime DateSet
        {
            get
            {
                return DateGet.AddDays(7);
            }
        }
        public bool Delivered { get; set; }
        public bool Notflicetion
        {
            get
            {
                return !Delivered && DateSet < DateTime.Now; 
            }
        }
        public Order()
        {
            OrderDetailse = new List<OrderDetailse>();
        }
    }
}
