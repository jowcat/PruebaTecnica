using ClientesApi.DTOs;
using ClientesApi.Repositories;
using AutoMapper;

namespace ClientesApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repo;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ClienteDto?> ObtenerPorIdentificacionAsync(string identificacion)
        {
            var cliente = await _repo.GetByIdentificacionAsync(identificacion);
            return cliente == null ? null : _mapper.Map<ClienteDto>(cliente);
        }
    }
}
