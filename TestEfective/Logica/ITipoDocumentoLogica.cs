using TestEfective.Modelos;

namespace TestEfective.Logica
{
    public interface ITipoDocumentoLogica
    {
        Task<List<TipoDocumento>> getAll();
    }
}
