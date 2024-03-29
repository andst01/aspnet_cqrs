using AutoMapper;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;

namespace SGAS.Infra.CrossCuting.AutoMapper
{
    public class CommandToDomainMappingProfile : Profile
    {
        public CommandToDomainMappingProfile()
        {
            CreateMap<AgendaCommand, Agenda>()
               .ForMember(x => x.Motivo, opt => opt.MapFrom(m => m.Motivo))
               .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
               .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario));

            CreateMap<AgendamentoCommand, Agendamento>()
                .ForMember(x => x.Atendente, opt => opt.MapFrom(x => x.Atendente))
                .ForMember(x => x.Servico, opt => opt.MapFrom(m => m.Servico))
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.ResponsavelServico, opt => opt.MapFrom(m => m.ResponsavelServico));

            CreateMap<CargoCommand, Cargo>()
               .ForMember(x => x.CargosFuncionario, opt => opt.MapFrom(m => m.CargosFuncionario));

            CreateMap<CargoFuncionarioCommand, CargoFuncionario>()
                 .ForMember(x => x.Cargo, opt => opt.MapFrom(m => m.Cargo))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario));

            CreateMap<CategoriaCommand, Categoria>()
                 .ForMember(x => x.Produto, opt => opt.MapFrom(m => m.Produto));

            CreateMap<CepCommand, Cep>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade));

            CreateMap<CidadeCommand, Cidade>()
               // .ForMember(x => x.Estado, opt => opt.MapFrom(m => m.Estado))
                .ForMember(x => x.Cep, opt => opt.MapFrom(m => m.Cep))
                .ForMember(x => x.MicrorRegiao, opt => opt.MapFrom(m => m.MicroRegiao))
                .ForMember(x => x.Endereco, opt => opt.MapFrom(m => m.Endereco));

            CreateMap<ClienteCommand, Cliente>()
                .ForMember(x => x.Agendamentos, opt => opt.MapFrom(m => m.Agendamentos))
                .ForMember(x => x.Vendas, opt => opt.MapFrom(m => m.Vendas))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

            CreateMap<EmpresaCommand, Empresa>()
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
                .ForMember(x => x.UnidadeVendas, opt => opt.MapFrom(m => m.UnidadeVendas));

            CreateMap<EnderecoCommand, Endereco>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

            CreateMap<EstadoCommand, Estado>()
                .ForMember(x => x.MesoRegiao, opt => opt.MapFrom(m => m.MesoRegiao))
                .ForMember(x => x.Regiao, opt => opt.MapFrom(m => m.Regiao))
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade));

            CreateMap<FornecedorCommand, Fornecedor>()
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

            CreateMap<FuncaoCommand, Funcao>()
                 .ForMember(x => x.FuncoesUsuarios, opt => opt.MapFrom(m => m.FuncoesUsuarios));

            CreateMap<FuncaoUsuarioCommand, FuncaoUsuario>()
                .ForMember(x => x.Role, opt => opt.MapFrom(m => m.Role))
                .ForMember(x => x.User, opt => opt.MapFrom(m => m.User));

            CreateMap<FuncionarioCommand, Funcionario>()
               .ForMember(x => x.Atendentes, opt => opt.MapFrom(m => m.Atendentes))
               .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
               .ForMember(x => x.CargosFuncionario, opt => opt.MapFrom(m => m.CargosFuncionario))
               .ForMember(x => x.ResponsaveisServico, opt => opt.MapFrom(m => m.ResponsaveisServico))
               .ForMember(x => x.Vendas, opt => opt.MapFrom(m => m.Vendas))
               .ForMember(x => x.Agendas, opt => opt.MapFrom(m => m.Agendas));

            CreateMap<ItemVendaCommand, ItemVenda>()
                .ForMember(x => x.Produto, opt => opt.MapFrom(m => m.Produto))
                .ForMember(x => x.Venda, opt => opt.MapFrom(m => m.Venda));

            CreateMap<MesoRegiaoCommand, MesoRegiao>()
                .ForMember(x => x.Uf, opt => opt.MapFrom(m => m.Estado))
                .ForMember(x => x.MicroRegiao, opt => opt.MapFrom(m => m.MicroRegiao));

            CreateMap<MicroRegiaoCommand, MicroRegiao>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade))
                .ForMember(x => x.MesorRegiao, opt => opt.MapFrom(m => m.MesoRegiao));

            CreateMap<MotivoCommand, Motivo>()
                .ForMember(x => x.Agenda, opt => opt.MapFrom(m => m.Agenda));

            CreateMap<PessoaCommand, Pessoa>()
                .ForMember(x => x.Endereco, opt => opt.MapFrom(m => m.Endereco))
                .ForMember(x => x.Usuario, opt => opt.MapFrom(m => m.Usuario))
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.Fornecedor, opt => opt.MapFrom(m => m.Fornecedor))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.Empresa, opt => opt.MapFrom(m => m.Empresa));

            CreateMap<ProdutoCommand, Produto>()
                .ForMember(x => x.Categoria, opt => opt.MapFrom(m => m.Categoria))
                .ForMember(x => x.ItemVendas, opt => opt.MapFrom(m => m.ItemVendas));

            CreateMap<RegiaoCommand, Regiao>()
                 .ForMember(x => x.Estados, opt => opt.MapFrom(m => m.Estados));

            CreateMap<ServicoCommand, Servico>()
                .ForMember(x => x.UsuarioResponsavel, opt => opt.MapFrom(m => m.UsuarioResponsavel))
                .ForMember(x => x.UsuarioCriacao, opt => opt.MapFrom(m => m.UsuarioCriacao));

            CreateMap<UnidadeVendaCommand, UnidadeVenda>()
                .ForMember(x => x.Agendamentos, opt => opt.MapFrom(m => m.Agendamentos))
                .ForMember(x => x.Agendas, opt => opt.MapFrom(m => m.Agendas))
                .ForMember(x => x.Empresa, opt => opt.MapFrom(m => m.Empresa))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));

            CreateMap<UsuarioCommand, Usuario>()
                 .ForMember(x => x.ServicoResponsavel, opt => opt.MapFrom(m => m.ServicoResponsavel))
                .ForMember(x => x.ServicoCriacao, opt => opt.MapFrom(m => m.ServicoCriacao))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
                .ForMember(x => x.FuncoesUsuarios, opt => opt.MapFrom(m => m.FuncoesUsuarios));

            CreateMap<VendaCommand, Venda>()
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.ItemVenda, opt => opt.MapFrom(m => m.ItemVenda));
        }
    }
}
