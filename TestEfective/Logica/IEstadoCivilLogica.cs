using TestEfective.Modelos;

namespace TestEfective.Logica
{
    public interface IEstadoCivilLogica
    {
        Task<List<EstadoCivil>> getAll();
    }
}
