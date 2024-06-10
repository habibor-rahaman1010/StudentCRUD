using Microsoft.AspNetCore.Mvc;

namespace StudentCURD.Controllers
{
    public class Account : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
