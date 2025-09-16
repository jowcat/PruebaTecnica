using AutoMapper;
using ClientesApi.Models;
using ClientesApi.DTOs;

namespace ClientesApi.API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDto>();
            CreateMap<ClienteDto, Cliente>();
        }
    }
}
