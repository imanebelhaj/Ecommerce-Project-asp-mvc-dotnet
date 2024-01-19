using EcomProjet3.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace EcomProjet3.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }




        // private readonly EcomDbContext _context;

        //public DetailsController(EcomDbContext context) 
        //{
        //    context = context;
        //}

        //public IActionResult Index(int? id)
        //{
        //    Product product = _context.Products.Find(id);

        //    if (product == null)
        //    {
        //        return NotFound(); // Return a 404 Not Found if the product is not found
        //    }

        //    return View(product);
        //}
    }
}
