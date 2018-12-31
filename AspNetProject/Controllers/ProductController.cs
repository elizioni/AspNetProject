using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetProject.Models;

namespace AspNetProject.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;


        public ProductController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Product


            [Authorize]
        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(c => c.AdId == id);
            return View(product);
        }
    }
}