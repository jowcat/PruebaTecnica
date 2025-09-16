using ClientesApi.DTOs;

namespace ClientesApi.Services
{
    public interface IClienteService
    {
        Task<ClienteDto?> ObtenerPorIdentificacionAsync(string identificacion);
    }
}
