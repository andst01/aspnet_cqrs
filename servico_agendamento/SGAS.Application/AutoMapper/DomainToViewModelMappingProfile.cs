using AutoMapper;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;

namespace SGAS.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Agendamento, AgendamentoViewModel>()
                .ForMember(x => x.Servico, opt => opt.MapFrom(m => m.Servico))
                .ForMember(x => x.ResponsavelServico, opt => opt.MapFrom(m => m.ResponsavelServico))
                .ForMember(x => x.Atendente, opt => opt.MapFrom(m => m.Atendente))
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda));

            CreateMap<Agenda, AgendaViewModel>()
                .ForMember(x => x.Motivo, opt => opt.MapFrom(m => m.Motivo))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda));

            CreateMap<Cargo, CargoViewModel>()
                .ForMember(x => x.CargosFuncionario, opt => opt.MapFrom(m => m.CargosFuncionario));

            CreateMap<CargoFuncionario, CargoFuncionarioViewModel>()
                .ForMember(x => x.Cargo, opt => opt.MapFrom(m => m.Cargo))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario));

            CreateMap<Categoria, CategoriaViewModel>()
                .ForMember(x => x.Produto, opt => opt.MapFrom(m => m.Produto));

            CreateMap<Cep, CepViewModel>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade));

            CreateMap<Cidade, CidadeViewModel>()
                .ForMember(x => x.Estado, opt => opt.MapFrom(m => m.Estado))
                .ForMember(x => x.Cep, opt => opt.MapFrom(m => m.Cep));

            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(x => x.Agendamentos, opt => opt.MapFrom(m => m.Agendamentos))
                .ForMember(x => x.Vendas, opt => opt.MapFrom(m => m.Vendas))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

            CreateMap<Empresa, EmpresaViewModel>()
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
                .ForMember(x => x.UnidadeVendas, opt => opt.MapFrom(m => m.UnidadeVendas));
               

            CreateMap<Endereco, EnderecoViewModel>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

            CreateMap<Estado, EstadoViewModel>()
                .ForMember(x => x.MesoRegiao, opt => opt.MapFrom(m => m.MesoRegiao))
                .ForMember(x => x.Regiao, opt => opt.MapFrom(m => m.Regiao))
                .ForMember(x => x.Cidade , opt => opt.MapFrom(m => m.Cidade));

            CreateMap<Fornecedor, FornecedorViewModel>()
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

            CreateMap<Funcao, FuncaoViewModel>()
                .ForMember(x => x.FuncoesUsuarios, opt => opt.MapFrom(m => m.FuncoesUsuarios));

            CreateMap<FuncaoUsuario, FuncaoUsuarioViewModel>()
                .ForMember(x => x.Role, opt => opt.MapFrom(m => m.Role))
                .ForMember(x => x.User, opt => opt.MapFrom(m => m.User));

            CreateMap<Funcionario, FuncionarioViewModel>()
                .ForMember(x => x.Atendentes, opt => opt.MapFrom(m => m.Atendentes))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
                .ForMember(x => x.CargosFuncionario, opt => opt.MapFrom(m => m.CargosFuncionario))
                .ForMember(x => x.ResponsaveisServico, opt => opt.MapFrom(m => m.ResponsaveisServico))
                .ForMember(x => x.Vendas, opt => opt.MapFrom(m => m.Vendas));

            CreateMap<ItemVenda, ItemVendaViewModel>()
                .ForMember(x => x.Produto, opt => opt.MapFrom(m => m.Produto))
                .ForMember(x => x.Venda, opt => opt.MapFrom(m => m.Venda));

            CreateMap<MesoRegiao, MesoRegiaoViewModel>()
                .ForMember(x => x.Estado, opt => opt.MapFrom(m => m.Estado))
                .ForMember(x => x.MicroRegiao, opt => opt.MapFrom(m => m.MicroRegiao));

            CreateMap<MicroRegiao, MicroRegiaoViewModel>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade))
                .ForMember(x => x.MesoRegiao, opt => opt.MapFrom(m => m.MesoRegiao));

            CreateMap<Motivo, MotivoViewModel>()
                .ForMember(x => x.Agenda, opt => opt.MapFrom(m => m.Agenda));

            CreateMap<Pessoa, PessoaViewModel>()
                .ForMember(x => x.Endereco, opt => opt.MapFrom(m => m.Endereco))
                .ForMember(x => x.Usuario, opt => opt.MapFrom(m => m.Usuario))
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.Fornecedor, opt => opt.MapFrom(m => m.Fornecedor))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.Empresa, opt => opt.MapFrom(m => m.Empresa));


            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(x => x.Categoria, opt => opt.MapFrom(m => m.Categoria))
                .ForMember(x => x.ItemVendas, opt => opt.MapFrom(m => m.ItemVendas));
                

            CreateMap<Regiao, RegiaoViewModel>()
                .ForMember(x => x.Estados, opt => opt.MapFrom(m => m.Estados));

            CreateMap<Servico, ServicoViewModel>()
                .ForMember(x => x.UsuarioResponsavel, opt => opt.MapFrom(m => m.UsuarioResponsavel))
                .ForMember(x => x.UsuarioCriacao, opt => opt.MapFrom(m => m.UsuarioCriacao));

            CreateMap<UnidadeVenda, UnidadeVendaViewModel>()
                .ForMember(x => x.Agendamentos, opt => opt.MapFrom(m => m.Agendamentos))
                .ForMember(x => x.Agendas, opt => opt.MapFrom(m => m.Agendas))
                .ForMember(x => x.Empresa, opt => opt.MapFrom(m => m.Empresa))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

            CreateMap<Usuario, UsuarioViewModel>()
                .ForMember(x => x.ServicoResponsavel, opt => opt.MapFrom(m => m.ServicoResponsavel))
                .ForMember(x => x.ServicoCriacao, opt => opt.MapFrom(m => m.ServicoCriacao))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
                .ForMember(x => x.FuncoesUsuarios, opt => opt.MapFrom(m => m.FuncoesUsuarios));

            CreateMap<Venda, VendaViewModel>()
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.ItemVenda, opt => opt.MapFrom(m => m.ItemVenda));


        }
    }
}
