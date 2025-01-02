using Microsoft.AspNetCore.Mvc;
using TestEfective.Logica;
using TestEfective.Modelos;


namespace TestEfective.Controllers
{
    [ApiController]
    [Route("TipoDocumento")]
    public class TipoDocumentoController : ControllerBase
    {

        private ITipoDocumentoLogica _Service;

        public TipoDocumentoController(ITipoDocumentoLogica repository)
        {
            _Service = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<TipoDocumento>>> Get()
        {
            return Ok(await _Service.getAll());
        }
    }
}
