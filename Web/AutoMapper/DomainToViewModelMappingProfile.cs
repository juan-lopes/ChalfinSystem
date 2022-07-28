using AutoMapper;
using Dominio.Advogado;
using Web.ViewModels;

namespace Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<AdvogadoViewModel, Advogado>();
        }
    }
}