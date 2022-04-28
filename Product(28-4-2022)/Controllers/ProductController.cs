using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductTable.Models;


namespace ProductTable.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Product/ADD")]
        public IActionResult Create(Product pro)
        {
            if(ModelState.IsValid)
            {
                ProductDBContext DbContext = new ProductDBContext();
                DbContext.Add(pro);
                DbContext.SaveChanges();
                return Content("Product Details Added");
            }
            return View("Index");
        }
    }
}
