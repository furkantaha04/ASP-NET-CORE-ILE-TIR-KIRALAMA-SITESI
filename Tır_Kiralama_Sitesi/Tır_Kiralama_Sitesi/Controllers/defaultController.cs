using Microsoft.AspNetCore.Mvc;

namespace travel_trip_project.Controllers
{
    public class defaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
