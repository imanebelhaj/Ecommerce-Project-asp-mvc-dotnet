using Microsoft.AspNetCore.Mvc;

namespace EcomProjet3.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
