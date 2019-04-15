using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestDemo.Models;

namespace TestDemo.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public ProductsController()
        {
            _dbContext = ApplicationDbContext.Create();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _dbContext.Dispose();
        }

        // GET: Products
        public ActionResult List()
        {
            var products = _dbContext.Products.Include(p => p.Manufacturer).ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ProductViewModel product)
        {
            var products = _dbContext.Products.Include(p => p.Manufacturer).ToList();
            return View("List");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel product)
        {
            return View("Edit", product);
        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }


    }
}