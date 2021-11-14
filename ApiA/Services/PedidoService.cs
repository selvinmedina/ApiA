using ApiA.Infraestructure;
using ApiA.Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiA.Services
{
    public class PedidoService
    {
        private readonly EcommerceContext _ecommerceContext;
        public PedidoService(EcommerceContext ecommerceContext)
        {
            _ecommerceContext = ecommerceContext;
        }

        public async Task<List<Pedido>> ObtenerPedidos()
        {
            try
            {
                var respuesta = await _ecommerceContext.Pedido.ToListAsync();

                return respuesta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return null;
            }
        }
    }
}
