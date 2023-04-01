using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class FornecedoresController : Controller
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
