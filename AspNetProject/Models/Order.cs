using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public string Email { get; set; }

        public double SumAmount { get; set; }
        public int Quantity
        {
            get
            {
                int sumQuantity = 0;    
                           
                    foreach (var item in OrderItems)
                    {
                        sumQuantity += item.Quantity;
                    }
                   return sumQuantity;
                
            }
        }

    }
}