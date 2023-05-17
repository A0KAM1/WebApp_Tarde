using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Entidades;
using WebApp_Tarde.Models;

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
            return View(db.Produtos.Include(a => a.Categoria).ToList());
        }

        public IActionResult Cadastro()
        {
            NovoProdutoViewModel model = new NovoProdutoViewModel();
            model.Lista_Categorias = db.CATEGORIA.ToList();
            return View(model);
        }

        public IActionResult Editar(int id)
        {
            return View(Cadastro);
        }

        public IActionResult SalvarDados(ProdutoEntidade dados)
        {
            if (dados.Id == 0)
            {
                db.Produtos.Add(dados);
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
