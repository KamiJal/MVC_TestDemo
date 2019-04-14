using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
    }
}