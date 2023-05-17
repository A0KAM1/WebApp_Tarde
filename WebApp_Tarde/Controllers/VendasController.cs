using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class VendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
