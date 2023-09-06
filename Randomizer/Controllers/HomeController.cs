using Microsoft.AspNetCore.Mvc;

namespace Randomizer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateRandomNumber(int minValue, int maxValue)
        {
            Random random = new Random();
            int randomNumber = random.Next(minValue, maxValue + 1);

            ViewBag.RandomNumber = randomNumber;

            return View("Index");
        }
    }
}
