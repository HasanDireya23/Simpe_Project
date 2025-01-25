using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebApplication6.Data;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDbContext _context;
       
        public ProductController(ProductDbContext p)
        {
            _context = p;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> products = _context.Products.ToList();//EF 
            
            return View(products);
        }





        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(Product p)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(p);// Add is EF Function Equivalent to Insert into
                _context.SaveChanges();
                return RedirectToAction("Index");
                
            }
            else
            {
                return View(p);
            }
        }

    }
}
