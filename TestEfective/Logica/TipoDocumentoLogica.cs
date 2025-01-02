using Microsoft.EntityFrameworkCore;
using TestEfective.Context;
using TestEfective.Modelos;


namespace TestEfective.Logica
{
    public class TipoDocumentoLogica : ITipoDocumentoLogica
    {

        private readonly testDBContext _context;

        public TipoDocumentoLogica(testDBContext context)
        {
            _context = context;
        }

        public async Task<List<TipoDocumento>> getAll()
        {
            try
            {
                List<TipoDocumento> data = new List<TipoDocumento>();

                data = await _context.TipoDocumentos.ToListAsync();

                return data;
            }
            catch (Exception ex)
            {
                return default;
            }
        }
    }
}
