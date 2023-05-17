namespace WebApp_Tarde.Entidades
{
    public class ItensVendaEntidade
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public ProdutoEntidade Produto { get; set; }
        public VendasEntidade Venda { get; set; }
        public decimal Valor { get; set; }
    }
}
