using System;
using System.Collections.Generic;

namespace ApiA.Infraestructure.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }

        public virtual List<PedidoDetalle> PedidoDetalles { get; set; }
    }
}
