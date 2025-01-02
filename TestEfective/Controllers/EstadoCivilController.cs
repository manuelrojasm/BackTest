using Microsoft.AspNetCore.Mvc;
using TestEfective.Logica;
using TestEfective.Modelos;


namespace TestEfective.Controllers
{
    [ApiController]
    [Route("EstadoCivil")]
    public class EstadoCivilController : ControllerBase
    {

        private IEstadoCivilLogica _Service;

        public EstadoCivilController(IEstadoCivilLogica repository)
        {
            _Service = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<EstadoCivil>>> Get()
        {
            return Ok(await _Service.getAll());
        }
    }
}
