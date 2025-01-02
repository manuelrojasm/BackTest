using Microsoft.EntityFrameworkCore;
using TestEfective.Context;
using TestEfective.Modelos;

namespace TestEfective.Logica
{
    public class EmpleadoLogica : IEmpleadoLogica
    {

        private readonly testDBContext _context;

        public EmpleadoLogica(testDBContext context)
        {
            _context = context;
        }

        public async Task<List<Empleado>> getAll()
        {
            try
            {
                List<Empleado> data = new List<Empleado>();

                data = await _context.Empleados.ToListAsync();

                return data;
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public async Task<Empleado> save(Empleado empleado)
        {
            try
            {
                _context.Empleados.Add(empleado);

                await _context.SaveChangesAsync();

                return empleado;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
