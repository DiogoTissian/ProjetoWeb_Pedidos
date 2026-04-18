using ftec.projetoweb.TrabalhoPedidos.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ftec.projetoweb.TrabalhoPedidos.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest("Erro");
            }
        }
    }
}
