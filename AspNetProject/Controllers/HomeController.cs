using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetProject.Models;
using System.Data.Entity;
using AspNetProject.ViewModels;

namespace AspNetProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            
        }
        //זה העמוד הראשי 
        public ActionResult Index()
        {
            // רשימה של מודעות מהמסד נתונים
            IEnumerable<Ad> ads = _context.Ads.ToList();

            return View(ads);
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to your shopping website!";

            return View();
        }
        [Authorize]
        public ActionResult New()
        {
            return View("NewAd");
        }

        
        public ActionResult CreateAd(AdProductViewModel adProduct)
        {
            var isSuchTitleExist = _context.Ads.FirstOrDefault(c => c.Title == adProduct.Title);

            //if an ad with the same title already exists, send back to createAd form
            if (isSuchTitleExist != null)
            {
                return RedirectToAction("Index");
            }

            //adding a new Ad to the database and saving
            var newAd = new Ad()
            {
                Description = adProduct.AdDescription,
                Image = adProduct.Image,
                Title = adProduct.Title,
                Date = adProduct.AdDate
            };

            _context.Ads.Add(newAd);
            _context.SaveChanges();

            //finding the ad id by locating it from the database
            var newAddedAd = _context.Ads.FirstOrDefault(c => c.Title == newAd.Title);
            //adding a new product to the database and saving
            var newProduct = new Product()
            {
                Description = adProduct.productDescription,
                AdId = newAddedAd.Id,
                Publisher = adProduct.productPublisher,
                firstImage = adProduct.productFirstImage,
                secondImage = adProduct.productSecondImage,
                Price = adProduct.productPrice

            };

            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}