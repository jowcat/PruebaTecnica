using Microsoft.AspNetCore.Mvc;
using ClientesApi.Services;
using ClientesApi.DTOs;

namespace ClientesApi.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClientesController(IClienteService service)
        {
            _service = service;
        }

        /// <summary>
        /// Obtiene los datos de un cliente por identificación
        /// </summary>
        /// <param name="identificacion">Número de identificación</param>
        /// <returns>Cliente encontrado</returns>
        [HttpGet("{identificacion}")]
        [ProducesResponseType(typeof(ClienteDto), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetCliente(string identificacion)
        {
            var cliente = await _service.ObtenerPorIdentificacionAsync(identificacion);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }
    }
}
