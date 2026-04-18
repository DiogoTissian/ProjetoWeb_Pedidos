namespace ftec.projetoweb.TrabalhoPedidos.api.Models
{
    public class PedidoModel
    {
        public PedidoModel()
        {
            this.Id = Guid.NewGuid();
            this.ProdutoId = Guid.Empty;
            this.Quantidade = 0;
        }

        public Guid Id { get; set; }
        public Guid ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
