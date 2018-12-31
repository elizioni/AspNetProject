using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetProject.Models;
using System.Data.Entity;
using AspNetProject.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace AspNetProject.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext _context;


        public OrderController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public ActionResult Create(int id,FormCollection collection)
        {
            OrderItem item = CreateOrderItem(id, collection);
            if (IsOrderExist())
            {
                var currentOrder = GetCurrentOrder();
                currentOrder.OrderItems.Add(item);

            }
            else
            {
                Order order = new Order() {Email = User.Identity.Name, OrderItems = new List<OrderItem>() {item}};
                _context.Orders.Add(order);
            }
            _context.SaveChanges();
           

            return RedirectToAction("Index","Home");
        }

        
        public ActionResult Remove(int id)
        {
            var orderItem = _context.OrderItems.SingleOrDefault(c => c.Id == id);
            if (orderItem != null)
            {
                _context.OrderItems.Remove(orderItem);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        private Order GetCurrentOrder()
        {
            var loggedUser = User.Identity.Name;

            return  _context.Orders.Include(c => c.OrderItems).SingleOrDefault(m => m.Email == loggedUser);
        }

        private OrderItem CreateOrderItem(int id, FormCollection collection)
        {
          OrderItem item = new OrderItem()
            {
                ProductId = id,
                Product = _context.Products.SingleOrDefault(a => a.Id == id),
                Quantity = Int32.Parse(collection["amount"])

            };

            return item;
        }

        public ActionResult Receipt()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var userAdress = user.Adress;
            return View((object)userAdress);
        }


        public ActionResult Index()
        {
            OrderViewModel orders = new OrderViewModel();
            
            var order = _context.Orders.Include(c => c.OrderItems).SingleOrDefault(c => c.Email == User.Identity.Name);
            if (order == null)
            {
                return View(orders);
            }

            SetProductsAndProductsNames(orders,order);
           
            order.SumAmount = CalculateSumAmount(orders.OrderItems);
            orders.TotalQuantity = order.Quantity;
            orders.TotalPrice = order.SumAmount;
            return View(orders);
        }

        private void SetProductsAndProductsNames(OrderViewModel orders,Order order)
        {
            orders.OrderItems = order.OrderItems.ToList();
            orders.ProductsName = new List<string>();
            foreach (var orderItem in orders.OrderItems)
            {
                var product = _context.Products.SingleOrDefault(c => c.Id == orderItem.ProductId);
                orderItem.Product = product;
                var productTitle = _context.Ads.SingleOrDefault(c => c.Id == orderItem.Product.AdId).Title;
                orders.ProductsName.Add(productTitle);

            }
        }
        private double CalculateSumAmount(List<OrderItem> orderItems)
        {
            double sum = 0;

            foreach (var item in orderItems)
            {
                sum += item.Product.Price * item.Quantity;
            }
            return sum;
        }

        private bool IsOrderExist()
        {
            var loggedUser = User.Identity.Name;

            var userNameMail = _context.Orders.SingleOrDefault(m => m.Email == loggedUser);

            return userNameMail != null;
        }
    }
}