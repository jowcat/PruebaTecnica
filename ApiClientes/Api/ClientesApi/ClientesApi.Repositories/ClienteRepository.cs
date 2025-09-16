using ClientesApi.Models;
using ClientesApi.Repositories.Data;
using Microsoft.EntityFrameworkCore;

namespace ClientesApi.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente?> GetByIdentificacionAsync(string identificacion)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.Identificacion == identificacion);
        }
    }
}