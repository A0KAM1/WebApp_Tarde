using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
