using AutoMapper;
using SGAS.Application.ViewModels;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;

namespace SGAS.Infra.CrossCuting.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
           
            CreateMap<AgendamentoViewModel, AgendamentoCreateCommand>();
            CreateMap<AgendamentoViewModel, AgendamentoUpdateCommand>();
            CreateMap<AgendamentoViewModel, AgendamentoDeleteCommand>();
               

            CreateMap<AgendaViewModel, Agenda>();
            CreateMap<AgendaViewModel, AgendaCreateCommand>();
            CreateMap<AgendaViewModel, AgendaUpdateCommand>();
            CreateMap<AgendaViewModel, AgendaDeleteCommand>();

            CreateMap<ServicoViewModel, Servico>();

            CreateMap<ServicoViewModel, ServicoCreateCommand>();
            CreateMap<ServicoViewModel, ServicoUpdateCommand>();
            CreateMap<ServicoViewModel, ServicoDeleteCommand>();

            CreateMap<MotivoViewModel, Motivo>();

            CreateMap<MotivoViewModel, MotivoCreateCommand>();
            CreateMap<MotivoViewModel, MotivoUpdateCommand>();
            CreateMap<MotivoViewModel, MotivoDeleteCommand>();
        }
    }
}
