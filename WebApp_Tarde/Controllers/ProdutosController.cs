using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Models;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly Contexto db;

        public ProdutosController(Contexto opt)
        {
            db = opt;
        }
        public IActionResult Lista()
        {
            return View(db.Produtos.ToList());
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            return View(Cadastro);
        }

        public IActionResult SalvarDados(ProdutoEntidade dados)
        {
            if (dados.Id == 0)
            {
                db.Add(dados);
                db.SaveChanges();
            }
            else
            {
                db.Update(dados);
            }
            return RedirectToAction("Lista");
        }

    }
}
