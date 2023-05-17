using WebApp_Tarde.Entidades;
namespace WebApp_Tarde.Models
{
    public class NovaVendaViewModel
    {
        public NovaVendaViewModel()
        {
            Lista_Produtos = new List<ProdutoEntidade>();
        }
        public List<ProdutoEntidade> Lista_Produtos { get; set; }
    }
}
