using Microsoft.AspNetCore.Mvc;

namespace Cozma_Laurentiu_Lab1.Controllers
{
    public class MyCustomController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to the custom controller!");
        }

        public IActionResult GreetUser()
        {
            string greet = "Hello user!";

            return Content(greet);
        }

        public IActionResult DisplayMessage(string message, int number)
        {
            message = "We have";
            number = 5;

            string result = $"{message} {number} cookies";

            return Content(result);
        }
    }
}
