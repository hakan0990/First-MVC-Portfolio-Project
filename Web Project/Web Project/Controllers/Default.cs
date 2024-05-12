using Microsoft.AspNetCore.Mvc;

namespace Web_Project.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
