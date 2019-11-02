using Microsoft.AspNetCore.Mvc;

namespace Tweetbook.Controllers{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}

