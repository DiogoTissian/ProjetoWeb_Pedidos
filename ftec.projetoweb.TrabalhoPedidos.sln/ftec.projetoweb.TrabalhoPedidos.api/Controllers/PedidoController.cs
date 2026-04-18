using ftec.projetoweb.TrabalhoPedidos.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ftec.projetoweb.TrabalhoPedidos.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(new List<PedidoModel>());
            }
            catch (Exception)
            {
                return BadRequest("Erro ao listar os pedidos");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(new PedidoModel());
            }
            catch (Exception)
            {
                return BadRequest("Erro ao retornar o pedido pesquisado");
            }
        }
    }
}
