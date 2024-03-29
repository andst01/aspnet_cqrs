using AutoMapper;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;

namespace SGAS.Infra.CrossCuting.AutoMapper
{
    public class DomainToEventMappingProfile : Profile
    {
        public DomainToEventMappingProfile()
        {
            #region Agenda

            CreateMap<Agenda, AgendaCreateNotification>()
                .ForMember(x => x.Motivo, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Agenda, AgendaUpdateNotification>()
               .ForMember(x => x.Motivo, opt => opt.Ignore())
               .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
               .ForMember(x => x.Funcionario, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Agenda, AgendaDeleteNotification>()
               .ForMember(x => x.Motivo, opt => opt.Ignore())
               .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
               .ForMember(x => x.Funcionario, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Agendamento

            CreateMap<Agendamento, AgendamentoCreateNotification>()
                .ForMember(x => x.Atendente, opt => opt.Ignore())
                .ForMember(x => x.Servico, opt => opt.Ignore())
                .ForMember(x => x.Cliente, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
                .ForMember(x => x.ResponsavelServico, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Agendamento, AgendamentoUpdateNotification>()
               .ForMember(x => x.Atendente, opt => opt.Ignore())
               .ForMember(x => x.Servico, opt => opt.Ignore())
               .ForMember(x => x.Cliente, opt => opt.Ignore())
               .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
               .ForMember(x => x.ResponsavelServico, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Agendamento, AgendamentoDeleteNotification>()
               .ForMember(x => x.Atendente, opt => opt.Ignore())
               .ForMember(x => x.Servico, opt => opt.Ignore())
               .ForMember(x => x.Cliente, opt => opt.Ignore())
               .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
               .ForMember(x => x.ResponsavelServico, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Cargo

            CreateMap<Cargo, CargoCreateNotification>()
                .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Cargo, CargoUpdateNotification>()
              .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Cargo, CargoDeleteNotification>()
              .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region CargoFuncionario

            CreateMap<CargoFuncionario, CargoFuncionarioCreateNotification>()
                 .ForMember(x => x.Cargo, opt => opt.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CargoFuncionario, CargoFuncionarioUpdateNotification>()
               .ForMember(x => x.Cargo, opt => opt.Ignore())
              .ForMember(x => x.Funcionario, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CargoFuncionario, CargoFuncionarioDeleteNotification>()
              .ForMember(x => x.Cargo, opt => opt.Ignore())
              .ForMember(x => x.Funcionario, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Categoria

            CreateMap<Categoria, CategoriaCreateNotification>()
                 .ForMember(x => x.Produto, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Categoria, CategoriaUpdateNotification>()
                .ForMember(x => x.Produto, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Categoria, CategoriaDeleteNotification>()
                .ForMember(x => x.Produto, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Cep

            CreateMap<Cep, CepCreateNotification>()
                .ForMember(x => x.Cidade, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Cep, CepUpdateNotification>()
               .ForMember(x => x.Cidade, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Cep, CepDeleteNotification>()
               .ForMember(x => x.Cidade, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Cidade

            CreateMap<Cidade, CidadeCreateNotification>()
                .ForMember(x => x.Estado, opt => opt.Ignore())
                .ForMember(x => x.Cep, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Cidade, CidadeUpdateNotification>()
                .ForMember(x => x.Estado, opt => opt.Ignore())
                .ForMember(x => x.Cep, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Cidade, CidadeDeleteNotification>()
                .ForMember(x => x.Estado, opt => opt.Ignore())
                .ForMember(x => x.Cep, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Cliente

            CreateMap<Cliente, ClienteCreateNotification>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore())
                .ForMember(x => x.Vendas, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Cliente, ClienteUpdateNotification>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore())
                .ForMember(x => x.Vendas, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Cliente, ClienteDeleteNotification>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore())
                .ForMember(x => x.Vendas, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Empresa

            CreateMap<Empresa, EmpresaCreateNotification>()
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVendas, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Empresa, EmpresaUpdateNotification>()
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVendas, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Empresa, EmpresaDeleteNotification>()
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVendas, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Endereco

            CreateMap<Endereco, EnderecoCreateNotification>()
                .ForMember(x => x.Cidade, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Endereco, EnderecoUpdateNotification>()
              .ForMember(x => x.Cidade, opt => opt.Ignore())
              .ForMember(x => x.Pessoa, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Endereco, EnderecoDeleteNotification>()
              .ForMember(x => x.Cidade, opt => opt.Ignore())
              .ForMember(x => x.Pessoa, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Estado

            CreateMap<Estado, EstadoCreateNotification>()
                .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
                .ForMember(x => x.Regiao, opt => opt.Ignore())
                .ForMember(x => x.Cidade, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Estado, EstadoUpdateNotification>()
              .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
              .ForMember(x => x.Regiao, opt => opt.Ignore())
              .ForMember(x => x.Cidade, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Estado, EstadoDeleteNotification>()
              .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
              .ForMember(x => x.Regiao, opt => opt.Ignore())
              .ForMember(x => x.Cidade, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Fornecedor

            CreateMap<Fornecedor, FornecedorCreateNotification>()
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Fornecedor, FornecedorUpdateNotification>()
              .ForMember(x => x.Pessoa, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Fornecedor, FornecedorDeleteNotification>()
              .ForMember(x => x.Pessoa, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Funcao

            CreateMap<Funcao, FuncaoCreateNotification>()
                 .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                  .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Funcao, FuncaoUpdateNotification>()
                .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Funcao, FuncaoDeleteNotification>()
                .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region FuncaUsuario

            CreateMap<FuncaoUsuario, FuncaoUsuarioCreateNotification>()
                .ForMember(x => x.Role, opt => opt.Ignore())
                .ForMember(x => x.User, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<FuncaoUsuario, FuncaoUsuarioUpdateNotification>()
              .ForMember(x => x.Role, opt => opt.Ignore())
              .ForMember(x => x.User, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<FuncaoUsuario, FuncaoUsuarioDeleteNotification>()
              .ForMember(x => x.Role, opt => opt.Ignore())
              .ForMember(x => x.User, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Funcionario

            CreateMap<Funcionario, FuncionarioCreateNotification>()
               .ForMember(x => x.Atendentes, opt => opt.Ignore())
               .ForMember(x => x.Pessoa, opt => opt.Ignore())
               .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
               .ForMember(x => x.ResponsaveisServico, opt => opt.Ignore())
               .ForMember(x => x.Vendas, opt => opt.Ignore())
               .ForMember(x => x.Agendas, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Funcionario, FuncionarioUpdateNotification>()
              .ForMember(x => x.Atendentes, opt => opt.Ignore())
              .ForMember(x => x.Pessoa, opt => opt.Ignore())
              .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
              .ForMember(x => x.ResponsaveisServico, opt => opt.Ignore())
              .ForMember(x => x.Vendas, opt => opt.Ignore())
              .ForMember(x => x.Agendas, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Funcionario, FuncionarioDeleteNotification>()
              .ForMember(x => x.Atendentes, opt => opt.Ignore())
              .ForMember(x => x.Pessoa, opt => opt.Ignore())
              .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
              .ForMember(x => x.ResponsaveisServico, opt => opt.Ignore())
              .ForMember(x => x.Vendas, opt => opt.Ignore())
              .ForMember(x => x.Agendas, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region ItemVenda

            CreateMap<ItemVenda, ItemVendaCreateNotification>()
                .ForMember(x => x.Produto, opt => opt.Ignore())
                .ForMember(x => x.Venda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<ItemVenda, ItemVendaUpdateNotification>()
              .ForMember(x => x.Produto, opt => opt.Ignore())
              .ForMember(x => x.Venda, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<ItemVenda, ItemVendaDeleteNotification>()
              .ForMember(x => x.Produto, opt => opt.Ignore())
              .ForMember(x => x.Venda, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region MesoRegiao

            CreateMap<MesoRegiao, MesoRegiaoCreateNotification>()
                .ForMember(x => x.Estado, opt => opt.Ignore())
                .ForMember(x => x.MicroRegiao, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<MesoRegiao, MesoRegiaoUpdateNotification>()
              .ForMember(x => x.Estado, opt => opt.Ignore())
              .ForMember(x => x.MicroRegiao, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<MesoRegiao, MesoRegiaoDeleteNotification>()
              .ForMember(x => x.Estado, opt => opt.Ignore())
              .ForMember(x => x.MicroRegiao, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region MicroRegiao

            CreateMap<MicroRegiao, MicroRegiaoCreateNotification>()
                .ForMember(x => x.Cidade, opt => opt.Ignore())
                .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<MicroRegiao, MicroRegiaoUpdateNotification>()
               .ForMember(x => x.Cidade, opt => opt.Ignore())
               .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<MicroRegiao, MicroRegiaoDeleteNotification>()
               .ForMember(x => x.Cidade, opt => opt.Ignore())
               .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Motivo

            CreateMap<Motivo, MotivoCreateNotification>()
                .ForMember(x => x.Agenda, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Motivo, MotivoUpdateNotification>()
               .ForMember(x => x.Agenda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Motivo, MotivoDeleteNotification>()
               .ForMember(x => x.Agenda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Pessoa

            CreateMap<Pessoa, PessoaCreateNotification>()
                .ForMember(x => x.Endereco, opt => opt.Ignore())
                .ForMember(x => x.Usuario, opt => opt.Ignore())
                .ForMember(x => x.Cliente, opt => opt.Ignore())
                .ForMember(x => x.Fornecedor, opt => opt.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
                .ForMember(x => x.Empresa, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Pessoa, PessoaUpdateNotification>()
               .ForMember(x => x.Endereco, opt => opt.Ignore())
               .ForMember(x => x.Usuario, opt => opt.Ignore())
               .ForMember(x => x.Cliente, opt => opt.Ignore())
               .ForMember(x => x.Fornecedor, opt => opt.Ignore())
               .ForMember(x => x.Funcionario, opt => opt.Ignore())
               .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
               .ForMember(x => x.Empresa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Pessoa, PessoaDeleteNotification>()
               .ForMember(x => x.Endereco, opt => opt.Ignore())
               .ForMember(x => x.Usuario, opt => opt.Ignore())
               .ForMember(x => x.Cliente, opt => opt.Ignore())
               .ForMember(x => x.Fornecedor, opt => opt.Ignore())
               .ForMember(x => x.Funcionario, opt => opt.Ignore())
               .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
               .ForMember(x => x.Empresa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Produto

            CreateMap<Produto, ProdutoCreateNotification>()
                .ForMember(x => x.Categoria, opt => opt.Ignore())
                .ForMember(x => x.ItemVendas, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Produto, ProdutoUpdateNotification>()
               .ForMember(x => x.Categoria, opt => opt.Ignore())
               .ForMember(x => x.ItemVendas, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Produto, ProdutoDeleteNotification>()
               .ForMember(x => x.Categoria, opt => opt.Ignore())
               .ForMember(x => x.ItemVendas, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Regiao

            CreateMap<Regiao, RegiaoCreateNotification>()
                 .ForMember(x => x.Estados, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Regiao, RegiaoUpdateNotification>()
                 .ForMember(x => x.Estados, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Regiao, RegiaoDeleteNotification>()
                 .ForMember(x => x.Estados, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Servico

            CreateMap<Servico, ServicoCreateNotification>()
                .ForMember(x => x.UsuarioResponsavel, opt => opt.Ignore())
                .ForMember(x => x.UsuarioCriacao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Servico, ServicoUpdateNotification>()
                .ForMember(x => x.UsuarioResponsavel, opt => opt.Ignore())
                .ForMember(x => x.UsuarioCriacao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Servico, ServicoDeleteNotification>()
                .ForMember(x => x.UsuarioResponsavel, opt => opt.Ignore())
                .ForMember(x => x.UsuarioCriacao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region UnidadeVenda

            CreateMap<UnidadeVenda, UnidadeVendaCreateNotification>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore())
                .ForMember(x => x.Agendas, opt => opt.Ignore())
                .ForMember(x => x.Empresa, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<UnidadeVenda, UnidadeVendaUpdateNotification>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore())
                .ForMember(x => x.Agendas, opt => opt.Ignore())
                .ForMember(x => x.Empresa, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());


            CreateMap<UnidadeVenda, UnidadeVendaDeleteNotification>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore())
                .ForMember(x => x.Agendas, opt => opt.Ignore())
                .ForMember(x => x.Empresa, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Usuario

            CreateMap<Usuario, UsuarioCreateNotification>()
                .ForMember(x => x.ServicoResponsavel, opt => opt.Ignore())
                .ForMember(x => x.ServicoCriacao, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Usuario, UsuarioUpdateNotification>()
                .ForMember(x => x.ServicoResponsavel, opt => opt.Ignore())
                .ForMember(x => x.ServicoCriacao, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Usuario, UsuarioDeleteNotification>()
                .ForMember(x => x.ServicoResponsavel, opt => opt.Ignore())
                .ForMember(x => x.ServicoCriacao, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Venda

            CreateMap<Venda, VendaCreateNotification>()
                .ForMember(x => x.Cliente, opt => opt.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
                .ForMember(x => x.ItemVenda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Venda, VendaUpdateNotification>()
               .ForMember(x => x.Cliente, opt => opt.Ignore())
               .ForMember(x => x.Funcionario, opt => opt.Ignore())
               .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
               .ForMember(x => x.ItemVenda, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<Venda, VendaDeleteNotification>()
               .ForMember(x => x.Cliente, opt => opt.Ignore())
               .ForMember(x => x.Funcionario, opt => opt.Ignore())
               .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
               .ForMember(x => x.ItemVenda, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion



        }
    }
}
