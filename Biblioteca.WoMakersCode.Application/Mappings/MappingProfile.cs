using AutoMapper;
using Biblioteca.WoMakersCode.Application.Models.AdicionarUsuario;
using Biblioteca.WoMakersCode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AdicionarUsuarioRequest, Usuario>()
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Endereco, fonte => fonte.MapFrom(src => src.Endereco))
                .ForMember(dest => dest.Telefone, fonte => fonte.MapFrom(src => src.Telefone));
        }
    }
}
