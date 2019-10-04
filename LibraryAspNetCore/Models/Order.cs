using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        //public Library Library { get; set; }
        public List<OrderDetailse> OrderDetailse { get; set; }
        public DateTime DateOrder { get; set; }
        [Required(ErrorMessage = "Вы не указали, когда заберёте Ваш заказ")]
        public DateTime DateGet { get; set; }
        public bool IsGet { get; set; }
        public bool DeliveredInLibrary { get; set; }
        public bool Notflicetion
        {
            get
            {
                return IsGet && !DeliveredInLibrary && DateGet.AddDays(7) < DateTime.Now; 
            }
        }
        public Order()
        {
            OrderDetailse = new List<OrderDetailse>();
        }
    }
}
