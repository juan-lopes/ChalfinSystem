using AutoMapper;
using Dominio.Advogado;
using Web.ViewModels;

namespace Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Advogado, AdvogadoViewModel>();
        }
    }
}