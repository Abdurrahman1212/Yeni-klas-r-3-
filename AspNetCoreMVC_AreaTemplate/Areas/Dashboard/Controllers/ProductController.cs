using AspNetCoreMVC_AreaTemplate.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMVC_AreaTemplate.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ProductController : Controller
    {
        private readonly NorthwindContext _context;

        public ProductController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //ProductCount
            ViewBag.ProductList = _context.Products.ToList();

            var product=_context.Products.ToList<Product>();

            return View(product);

        }
        [HttpGet]
        public IActionResult Create(Product product)
        {
            
            var _product = _context.Products.Add;
            return View();
        }
        [HttpPost]
        public IActionResult Create()
        {
            ViewBag.CreateProduct = _context.Products.ToList();
            ViewBag.AddProduct = _context.SaveChanges();
            

            return RedirectToAction ("Product/Index");
        }
    }
}
