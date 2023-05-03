using Microsoft.EntityFrameworkCore;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        { }

        public DbSet<ProdutoEntidade> Produtos { get; set; }
        public DbSet<PermissaoEntidade> PERMISSAO { get; set; }
        public DbSet<CategoriaEntidade> CATEGORIA { get; set; }
    }
}
