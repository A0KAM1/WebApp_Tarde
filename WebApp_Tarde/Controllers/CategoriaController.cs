using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde.Controllers
{
    public class CategoriaController : Controller
    {
        private Contexto contexto;

        public CategoriaController(Contexto db)
        {
            contexto = db;
        }

        public IActionResult Lista()
        {
            return View(contexto.CATEGORIA.ToList());
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(CategoriaEntidade dados)
        {
            if(dados.Id != null)
            {
                contexto.CATEGORIA.Update(dados);
                contexto.SaveChanges();
            }
            else
            {
                contexto.CATEGORIA.Add(dados);
                contexto.SaveChanges();
            }
                 return RedirectToAction("Lista");           
        }
        public IActionResult Excluir(CategoriaEntidade id, CategoriaEntidade dados)
        {
            if (id != null)
            {
                contexto.CATEGORIA.Remove(dados);
                contexto.SaveChanges();
            }
            return RedirectToAction("Lista");
        }
        public IActionResult Editar(CategoriaEntidade dados)
        {

            return View(dados);

        }
    }
}
