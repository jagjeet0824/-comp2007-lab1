using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Store/Details
        public ActionResult Details(string Products)
        {
            ViewBag.Products = Products;
            return View();
        }

    }
}