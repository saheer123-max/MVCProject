    using Microsoft.AspNetCore.Mvc;

    namespace MVC.Controllers
    {
        [Route("Main")]
        public class MainController : Controller
        {
            [Route("")]
            public IActionResult Index()
            {
                return Content("this home inside index rout purpuse");
            }

            [Route("{id}")]

            public IActionResult Detils(int id)
            {
                return Content("this id  "+ id);
            }
        }
    }
