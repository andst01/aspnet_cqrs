using AutoMapper;
using SGAS.Application.ViewModels;
using SGAS.Domain.Notifications;

namespace SGAS.Infra.CrossCuting.AutoMapper
{
    public class EventToViewModelMappingProfile : Profile
    {
        public EventToViewModelMappingProfile()
        {
            CreateMap<AgendaNotification, AgendaViewModel>()
                .ForMember(x => x.Motivo, opt => opt.MapFrom(m => m.Motivo))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario));

            CreateMap<AgendamentoNotification, AgendamentoViewModel>()
                .ForMember(x => x.Atendente, opt => opt.MapFrom(x => x.Atendente))
                .ForMember(x => x.Servico, opt => opt.MapFrom(m => m.Servico))
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.ResponsavelServico, opt => opt.MapFrom(m => m.ResponsavelServico));

            CreateMap<CargoNotification, CargoViewModel>()
                .ForMember(x => x.CargosFuncionario, opt => opt.MapFrom(m => m.CargosFuncionario));

            CreateMap<CargoFuncionarioNotification, CargoFuncionarioViewModel>()
                 .ForMember(x => x.Cargo, opt => opt.MapFrom(m => m.Cargo))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario));

            CreateMap<CategoriaNotification, CategoriaViewModel>()
                .ForMember(x => x.Produto, opt => opt.MapFrom(m => m.Produto));

            CreateMap<CepNotification, CepViewModel>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade));

            CreateMap<CidadeNotification, CidadeViewModel>()
                .ForMember(x => x.Estado, opt => opt.MapFrom(m => m.Estado))
                .ForMember(x => x.Cep, opt => opt.MapFrom(m => m.Cep));

            CreateMap<ClienteNotification, ClienteViewModel>()
                .ForMember(x => x.Agendamentos, opt => opt.MapFrom(m => m.Agendamentos))
                .ForMember(x => x.Vendas, opt => opt.MapFrom(m => m.Vendas))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

            CreateMap<EmpresaNotification, EmpresaViewModel>()
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
                .ForMember(x => x.UnidadeVendas, opt => opt.MapFrom(m => m.UnidadeVendas));

            CreateMap<EnderecoNotification, EnderecoViewModel>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

            CreateMap<EstadoNotification, EstadoViewModel>()
                .ForMember(x => x.MesoRegiao, opt => opt.MapFrom(m => m.MesoRegiao))
                .ForMember(x => x.Regiao, opt => opt.MapFrom(m => m.Regiao))
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade));

            CreateMap<FornecedorNotification, FornecedorViewModel>()
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));


            CreateMap<FuncaoNotification, FuncaoViewModel>()
                .ForMember(x => x.FuncoesUsuarios, opt => opt.MapFrom(m => m.FuncoesUsuarios));

            CreateMap<FuncaoUsuarioNotification, FuncaoUsuarioViewModel>()
                .ForMember(x => x.Role, opt => opt.MapFrom(m => m.Role))
                .ForMember(x => x.User, opt => opt.MapFrom(m => m.User));

            CreateMap<FuncionarioNotification, FuncionarioViewModel>()
               .ForMember(x => x.Atendentes, opt => opt.MapFrom(m => m.Atendentes))
               .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
               .ForMember(x => x.CargosFuncionario, opt => opt.MapFrom(m => m.CargosFuncionario))
               .ForMember(x => x.ResponsaveisServico, opt => opt.MapFrom(m => m.ResponsaveisServico))
               .ForMember(x => x.Vendas, opt => opt.MapFrom(m => m.Vendas))
               .ForMember(x => x.Agendas, opt => opt.MapFrom(m => m.Agendas));

            CreateMap<ItemVendaNotification, ItemVendaViewModel>()
               .ForMember(x => x.Produto, opt => opt.MapFrom(m => m.Produto))
               .ForMember(x => x.Venda, opt => opt.MapFrom(m => m.Venda));

            CreateMap<MesoRegiaoNotification, MesoRegiaoViewModel>()
                .ForMember(x => x.Estado, opt => opt.MapFrom(m => m.Estado))
                .ForMember(x => x.MicroRegiao, opt => opt.MapFrom(m => m.MicroRegiao));

            CreateMap<MicroRegiaoNotification, MicroRegiaoViewModel>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade))
                .ForMember(x => x.MesoRegiao, opt => opt.MapFrom(m => m.MesoRegiao));

            CreateMap<MotivoNotification, MotivoViewModel>()
                .ForMember(x => x.Agenda, opt => opt.MapFrom(m => m.Agenda));

            CreateMap<PessoaNotification, PessoaViewModel>()
                .ForMember(x => x.Endereco, opt => opt.MapFrom(m => m.Endereco))
                .ForMember(x => x.Usuario, opt => opt.MapFrom(m => m.Usuario))
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.Fornecedor, opt => opt.MapFrom(m => m.Fornecedor))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.Empresa, opt => opt.MapFrom(m => m.Empresa));

            CreateMap<ProdutoNotification, ProdutoViewModel>()
                .ForMember(x => x.Categoria, opt => opt.MapFrom(m => m.Categoria))
                .ForMember(x => x.ItemVendas, opt => opt.MapFrom(m => m.ItemVendas));

            CreateMap<RegiaoNotification, RegiaoViewModel>()
                 .ForMember(x => x.Estados, opt => opt.MapFrom(m => m.Estados));

            CreateMap<ServicoNotification, ServicoViewModel>()
                .ForMember(x => x.UsuarioResponsavel, opt => opt.MapFrom(m => m.UsuarioResponsavel))
                .ForMember(x => x.UsuarioCriacao, opt => opt.MapFrom(m => m.UsuarioCriacao));

            CreateMap<UnidadeVendaNotification, UnidadeVendaViewModel>()
                .ForMember(x => x.Agendamentos, opt => opt.MapFrom(m => m.Agendamentos))
                .ForMember(x => x.Agendas, opt => opt.MapFrom(m => m.Agendas))
                .ForMember(x => x.Empresa, opt => opt.MapFrom(m => m.Empresa))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

        }
    }
}
