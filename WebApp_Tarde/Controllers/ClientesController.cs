using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Models;

namespace WebApp_Tarde.Controllers
{
    public class ClientesController : Controller
    {
        public static List<ClientesViewModel> db = new List<ClientesViewModel>();
        public IActionResult Lista()
        {
            return View(db);
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(ClientesViewModel dados)
        {
            if (dados.ID == 0)
            {
                Random rand = new Random();
                int aleat = rand.Next(1, 9999);
                //gerando um ID aleatorio
                dados.ID = aleat;
                //adicionando os dados no "banco"
                db.Add(dados);
            }
            else
            {
                int indice = db.FindIndex(a => a.ID == dados.ID);
                db[indice] = dados;
            }
            return RedirectToAction("Lista");
        }

        public IActionResult Excluir(int id)
        {
            ClientesViewModel cliente = db.Find(a => a.ID == id);
            if(cliente != null)
            {
                db.Remove(cliente);
            }

            return RedirectToAction("Lista");
        }

        public IActionResult Editar(int id)
        {
            ClientesViewModel cliente = db.Find(a => a.ID == id);
            if(cliente != null)
            {
                return View(cliente);
            }
            else
            {
                return RedirectToAction("Lista");
            }
        }

    }
}
