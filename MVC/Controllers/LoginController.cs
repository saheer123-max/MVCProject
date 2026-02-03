using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return Content("this is login page");
        }

        [Route("{id}")]
        public IActionResult Error(int id)

        {
            return Content("this login  submit button" + id);
        }
    }
}
