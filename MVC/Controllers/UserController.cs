using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile(string Username)
        {

            ViewBag.Name = Username;
            return View();
        }
    }
}
