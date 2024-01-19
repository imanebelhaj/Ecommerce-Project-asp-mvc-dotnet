using Microsoft.AspNetCore.Mvc;

namespace EcomProjet3.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Thankyou()
        {
            return View();
        }
    }
}
