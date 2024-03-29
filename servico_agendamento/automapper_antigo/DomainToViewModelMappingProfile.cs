using AutoMapper;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;

namespace SGAS.Infra.CrossCuting.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Agendamento, AgendamentoViewModel>()
                .ForMember(x => x.Servico, opt => opt.Ignore());

            CreateMap<Agenda, AgendaViewModel>();

            CreateMap<Servico, ServicoViewModel>();

            CreateMap<Motivo, MotivoViewModel>();

        }
    }
}
