using Microsoft.AspNetCore.Mvc;
using TestEfective.Logica;
using TestEfective.Modelos;


namespace TestEfective.Controllers
{
    [ApiController]
    [Route("Empleado")]
    public class EmpleadoController : ControllerBase
    {
        private IEmpleadoLogica _Service;

        public EmpleadoController(IEmpleadoLogica repository)
        {
            _Service = repository;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _Service.getAll());
        }

        [HttpPost]
        public async Task<ActionResult<Empleado>> CrearEmpleado([FromBody] Empleado empleado)
        {
            if (empleado == null)
            {
                return BadRequest("Los datos del empleado no son válidos.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var respuesta = await _Service.save(empleado);

            if (respuesta == null) {

                return BadRequest("Error al insertar");
            }

            return Ok(respuesta);

        }

    }
}
