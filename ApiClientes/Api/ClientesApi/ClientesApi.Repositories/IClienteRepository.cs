using ClientesApi.Models;

namespace ClientesApi.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente?> GetByIdentificacionAsync(string identificacion);
    }
}
