using ApiA.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiA.Controllers
{
    [ApiController]
    [Route("Pedido")]
    public class PedidosController: ControllerBase
    {
        private readonly PedidoService _pedidoService;
        public PedidosController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerPedidos()
        {
            var respuesta = await _pedidoService.ObtenerPedidos();

            return Ok(respuesta);
        }
    }
}
