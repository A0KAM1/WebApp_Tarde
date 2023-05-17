namespace WebApp_Tarde.Entidades
{
    public class ProdutoEntidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public CategoriaEntidade Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
