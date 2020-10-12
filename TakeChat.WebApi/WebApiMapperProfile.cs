using AutoMapper;
using TakeChat.Domain.Models;
using TakeChat.WebApi.Dtos;
using TakeChat.WebApi.Dtos.Sala;
using TakeChat.WebApi.Dtos.Usuario;

namespace TakeChat.WebApi
{
    public class WebApiMapperProfile : Profile
    {
        public WebApiMapperProfile()
        {
            CreateMap<Sala, SalaGetResult>();
            CreateMap<SalaGet, Sala>();
            CreateMap<SalaPost, Sala>();
            CreateMap<UsuarioPost, Usuario>();
        }
    }
}
