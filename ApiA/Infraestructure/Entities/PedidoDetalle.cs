namespace ApiA.Infraestructure.Entities
{
    public class PedidoDetalle
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }
        public int PedidoId { get; set; }

        public virtual Pedido Pedido { get; set; }
    }
}
