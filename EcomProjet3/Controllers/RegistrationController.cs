using EcomProjet3.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EcomProjet3.Controllers
{
    public class AccountController : Controller
    {
        public string value = "";

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }



    }
}
