using Microsoft.EntityFrameworkCore;
using TestEfective.Context;
using TestEfective.Modelos;

namespace TestEfective.Logica
{
    public class EstadoCivilLogica : IEstadoCivilLogica
    {
        private readonly testDBContext _context;

        public EstadoCivilLogica(testDBContext context)
        {
            _context = context;
        }

        public async Task<List<EstadoCivil>> getAll()
        {
            try
            {
                List<EstadoCivil> data = new List<EstadoCivil>();

                data = await _context.estadoCivil.ToListAsync();

                return data;
            }
            catch (Exception ex)
            {
                return default;
            }
        }
    }
}
