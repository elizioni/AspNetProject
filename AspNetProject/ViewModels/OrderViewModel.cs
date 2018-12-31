using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetProject.Models;

namespace AspNetProject.ViewModels
{
    public class OrderViewModel
    {
        public List<OrderItem> OrderItems { get; set; }
        public List<string>  ProductsName { get; set; }
        public double TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
    }
}