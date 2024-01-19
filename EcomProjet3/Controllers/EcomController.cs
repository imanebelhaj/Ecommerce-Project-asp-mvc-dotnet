using EcomProjet3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcomProjet3.Controllers
{
    public class EcomController : Controller
    {
        private readonly EcommerceDbContext _context;

        public IActionResult Index()
        {
            return View();
        }
        public EcomController(EcommerceDbContext context)
        {
            _context = context;
        }

        //public IActionResult Details(int id)
        //{
        //    // Retrieve the product from the database using the context
        //    var product = _context.Products.Find(id);

        //    // Check if the product is null
        //    if (product == null)
        //    {
        //        return NotFound(); // Or handle the case where the product is not found
        //    }

        //    // Pass the product to the view
        //    return View(product);
        //}

    }
}
