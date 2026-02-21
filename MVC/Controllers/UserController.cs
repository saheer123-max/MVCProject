using Microsoft.AspNetCore.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class UserController : Controller
    {
     

        public IActionResult Profile()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "saheeraslam",
                Age = 18

            };

            return View(student);


        }
        public IActionResult ind



    }
}
