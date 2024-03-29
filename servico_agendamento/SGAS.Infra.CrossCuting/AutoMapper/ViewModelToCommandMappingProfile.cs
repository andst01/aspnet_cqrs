using AutoMapper;
using SGAS.Application.ViewModels;
using SGAS.Domain.Command;

namespace SGAS.Infra.CrossCuting.AutoMapper
{
    public class ViewModelToCommandMappingProfile : Profile
    {
        public ViewModelToCommandMappingProfile()
        {
            #region Agenda

            CreateMap<AgendaViewModel, AgendaCommand>()
                .ForMember(x => x.Motivo, opt => opt.MapFrom(m => m.Motivo))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario));



            #endregion

            #region Agendamento
            CreateMap<AgendamentoViewModel, AgendamentoCommand>()
                .ForMember(x => x.Atendente, opt => opt.MapFrom(x => x.Atendente))
                .ForMember(x => x.Servico, opt => opt.MapFrom(m => m.Servico))
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.ResponsavelServico, opt => opt.MapFrom(m => m.ResponsavelServico));


            #endregion

            #region Cargo

            CreateMap<CargoViewModel, CargoCommand>()
               .ForMember(x => x.CargosFuncionario, opt => opt.MapFrom(m => m.CargosFuncionario));

   

            #endregion

            #region CargoFuncionario

            CreateMap<CargoFuncionarioViewModel, CargoFuncionarioCommand>()
                 .ForMember(x => x.Cargo, opt => opt.MapFrom(m => m.Cargo))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario));



            #endregion

            #region Categoria

            CreateMap<CategoriaViewModel, CategoriaCommand>()
                 .ForMember(x => x.Produto, opt => opt.MapFrom(m => m.Produto));

 

            #endregion

            #region Cep

            CreateMap<CepViewModel, CepCommand>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade));

   
            #endregion

            #region Cidade

            CreateMap<CidadeViewModel, CidadeCommand>()
                .ForMember(x => x.Estado, opt => opt.MapFrom(m => m.Estado))
                .ForMember(x => x.Cep, opt => opt.MapFrom(m => m.Cep))
                .ForMember(x => x.MicroRegiao, opt => opt.MapFrom(m => m.MicroRegiao))
                .ForMember(x => x.Endereco, opt => opt.MapFrom(m => m.Endereco));

 
            #endregion

            #region Cliente

            CreateMap<ClienteViewModel, ClienteCommand>()
                .ForMember(x => x.Agendamentos, opt => opt.MapFrom(m => m.Agendamentos))
                .ForMember(x => x.Vendas, opt => opt.MapFrom(m => m.Vendas))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));



            #endregion

            #region Empresa

            CreateMap<EmpresaViewModel, EmpresaCommand>()
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
                .ForMember(x => x.UnidadeVendas, opt => opt.MapFrom(m => m.UnidadeVendas));


            #endregion

            #region Endereco

            CreateMap<EnderecoViewModel, EnderecoCommand>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));


            #endregion

            #region Estado

            CreateMap<EstadoViewModel, EstadoCommand>()
                .ForMember(x => x.MesoRegiao, opt => opt.MapFrom(m => m.MesoRegiao))
                .ForMember(x => x.Regiao, opt => opt.MapFrom(m => m.Regiao))
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade));


            #endregion

            #region Fornecedor

            CreateMap<FornecedorViewModel, FornecedorCommand>()
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));


            #endregion

            #region Funcao

            CreateMap<FuncaoViewModel, FuncaoCommand>()
                 .ForMember(x => x.FuncoesUsuarios, opt => opt.MapFrom(m => m.FuncoesUsuarios));

            #endregion

            #region  FuncaoUsuario

            CreateMap<FuncaoUsuarioViewModel, FuncaoUsuarioCommand>()
                .ForMember(x => x.Role, opt => opt.MapFrom(m => m.Role))
                .ForMember(x => x.User, opt => opt.MapFrom(m => m.User));

 

            #endregion

            #region Funcionario

            CreateMap<FuncionarioViewModel, FuncionarioCommand>()
               .ForMember(x => x.Atendentes, opt => opt.MapFrom(m => m.Atendentes))
               .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
               .ForMember(x => x.CargosFuncionario, opt => opt.MapFrom(m => m.CargosFuncionario))
               .ForMember(x => x.ResponsaveisServico, opt => opt.MapFrom(m => m.ResponsaveisServico))
               .ForMember(x => x.Vendas, opt => opt.MapFrom(m => m.Vendas))
               .ForMember(x => x.Agendas, opt => opt.MapFrom(m => m.Agendas));

       

            #endregion

            #region ItemVanda

            CreateMap<ItemVendaViewModel, ItemVendaCommand>()
                .ForMember(x => x.Produto, opt => opt.MapFrom(m => m.Produto))
                .ForMember(x => x.Venda, opt => opt.MapFrom(m => m.Venda));

    

            #endregion

            #region MesoRegiao

            CreateMap<MesoRegiaoViewModel, MesoRegiaoCommand>()
                .ForMember(x => x.Estado, opt => opt.MapFrom(m => m.Estado))
                .ForMember(x => x.MicroRegiao, opt => opt.MapFrom(m => m.MicroRegiao));



            #endregion

            #region MicroRegiao

            CreateMap<MicroRegiaoViewModel, MicroRegiaoCommand>()
                .ForMember(x => x.Cidade, opt => opt.MapFrom(m => m.Cidade))
                .ForMember(x => x.MesoRegiao, opt => opt.MapFrom(m => m.MesoRegiao));


            #endregion

            #region Motivo

            CreateMap<MotivoViewModel, MotivoCommand>()
                .ForMember(x => x.Agenda, opt => opt.MapFrom(m => m.Agenda));


            #endregion

            #region Pessoa

            CreateMap<PessoaViewModel, PessoaCommand>()
                .ForMember(x => x.Endereco, opt => opt.MapFrom(m => m.Endereco))
                .ForMember(x => x.Usuario, opt => opt.MapFrom(m => m.Usuario))
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.Fornecedor, opt => opt.MapFrom(m => m.Fornecedor))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.Empresa, opt => opt.MapFrom(m => m.Empresa));


            #endregion

            #region Produto

            CreateMap<ProdutoViewModel, ProdutoCommand>()
                .ForMember(x => x.Categoria, opt => opt.MapFrom(m => m.Categoria))
                .ForMember(x => x.ItemVendas, opt => opt.MapFrom(m => m.ItemVendas));



            #endregion

            #region Regiao

            CreateMap<RegiaoViewModel, RegiaoCommand>()
                 .ForMember(x => x.Estados, opt => opt.MapFrom(m => m.Estados));



            #endregion

            #region Servico

            CreateMap<ServicoViewModel, ServicoCommand>()
                .ForMember(x => x.UsuarioResponsavel, opt => opt.MapFrom(m => m.UsuarioResponsavel))
                .ForMember(x => x.UsuarioCriacao, opt => opt.MapFrom(m => m.UsuarioCriacao));



            #endregion

            #region UnidadeVenda

            CreateMap<UnidadeVendaViewModel, UnidadeVendaCommand>()
                .ForMember(x => x.Agendamentos, opt => opt.MapFrom(m => m.Agendamentos))
                .ForMember(x => x.Agendas, opt => opt.MapFrom(m => m.Agendas))
                .ForMember(x => x.Empresa, opt => opt.MapFrom(m => m.Empresa))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa));



            #endregion

            #region Usuario

            CreateMap<UsuarioViewModel, UsuarioCommand>()
                 .ForMember(x => x.ServicoResponsavel, opt => opt.MapFrom(m => m.ServicoResponsavel))
                .ForMember(x => x.ServicoCriacao, opt => opt.MapFrom(m => m.ServicoCriacao))
                .ForMember(x => x.Pessoa, opt => opt.MapFrom(m => m.Pessoa))
                .ForMember(x => x.FuncoesUsuarios, opt => opt.MapFrom(m => m.FuncoesUsuarios));




            #endregion

            #region Venda

            CreateMap<VendaViewModel, VendaCommand>()
                .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario))
                .ForMember(x => x.UnidadeVenda, opt => opt.MapFrom(m => m.UnidadeVenda))
                .ForMember(x => x.ItemVenda, opt => opt.MapFrom(m => m.ItemVenda));



            #endregion


        }
    }
}
