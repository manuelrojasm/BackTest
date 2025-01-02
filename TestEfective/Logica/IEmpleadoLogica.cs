using TestEfective.Modelos;

namespace TestEfective.Logica
{
    public interface IEmpleadoLogica
    {
        Task<List<Empleado>> getAll();
        Task<Empleado> save(Empleado empleado);
    }
}
