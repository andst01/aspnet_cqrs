using AutoMapper;
using SGAS.Domain.Command;
using SGAS.Domain.Notifications;

namespace SGAS.Infra.CrossCuting.AutoMapper
{
    public class CommandToEventMappingProfile : Profile
    {
        public CommandToEventMappingProfile()
        {
            #region Agenda

            CreateMap<AgendaCreateCommand, AgendaCreateNotification>()
                .ForMember(x => x.Motivo, y => y.Ignore())
                .ForMember(x => x.UnidadeVenda, y => y.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore());

            CreateMap<AgendaUpdateCommand, AgendaUpdateNotification>()
                 .ForMember(x => x.Motivo, y => y.Ignore())
                 .ForMember(x => x.UnidadeVenda, y => y.Ignore())
                 .ForMember(x => x.Funcionario, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<AgendaDeleteCommand, AgendaDeleteNotification>()
                .ForMember(x => x.Motivo, y => y.Ignore())
                .ForMember(x => x.UnidadeVenda, y => y.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Agendamento

            CreateMap<AgendamentoCreateCommand, AgendamentoCreateNotification>()
                .ForMember(x => x.Atendente, opt => opt.Ignore())
                .ForMember(x => x.Servico, opt => opt.Ignore())
                .ForMember(x => x.Cliente, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
                .ForMember(x => x.ResponsavelServico, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());


            CreateMap<AgendamentoUpdateCommand, AgendamentoUpdateNotification>()
               .ForMember(x => x.Atendente, opt => opt.Ignore())
               .ForMember(x => x.Servico, opt => opt.Ignore())
               .ForMember(x => x.Cliente, opt => opt.Ignore())
               .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
               .ForMember(x => x.ResponsavelServico, opt => opt.MapFrom(m => m.ResponsavelServico))
               .ForMember(x => x._Id, opt => opt.Ignore());


            CreateMap<AgendamentoDeleteCommand, AgendamentoDeleteNotification>()
              .ForMember(x => x.Atendente, opt => opt.MapFrom(x => x.Atendente))
              .ForMember(x => x.Servico, opt => opt.MapFrom(m => m.Servico))
              .ForMember(x => x.Cliente, opt => opt.MapFrom(m => m.Cliente))
              .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
              .ForMember(x => x.ResponsavelServico, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Cargo

            CreateMap<CargoCreateCommand, CargoCreateNotification>()
               .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
               .ForMember(x => x._Id, opt=> opt.Ignore());

            CreateMap<CargoUpdateCommand, CargoUpdateNotification>()
              .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CargoDeleteCommand, CargoDeleteNotification>()
             .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
             .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region CargoFuncionario

            CreateMap<CargoFuncionarioCreateCommand, CargoFuncionarioCreateNotification>()
                 .ForMember(x => x.Cargo, opt => opt.MapFrom(m => m.Cargo))
                .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario))
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CargoFuncionarioCreateCommand, CargoFuncionarioUpdateNotification>()
                .ForMember(x => x.Cargo, opt => opt.MapFrom(m => m.Cargo))
               .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario))
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CargoFuncionarioDeleteCommand, CargoFuncionarioDeleteNotification>()
               .ForMember(x => x.Cargo, opt => opt.MapFrom(m => m.Cargo))
              .ForMember(x => x.Funcionario, opt => opt.MapFrom(m => m.Funcionario))
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Categoria

            CreateMap<CategoriaCreateCommand, CategoriaCreateNotification>()
                 .ForMember(x => x.Produto, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CategoriaUpdateCommand, CategoriaUpdateNotification>()
                .ForMember(x => x.Produto, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CategoriaDeleteCommand, CategoriaDeleteNotification>()
               .ForMember(x => x.Produto, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Cep

            CreateMap<CepCreateCommand, CepCreateNotification>()
                .ForMember(x => x.Cidade, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CepUpdateCommand, CepUpdateNotification>()
               .ForMember(x => x.Cidade, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CepDeleteCommand, CepDeleteNotification>()
               .ForMember(x => x.Cidade, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Cidade

            CreateMap<CidadeCreateCommand, CidadeCreateNotification>()
                .ForMember(x => x.Estado, opt => opt.Ignore())
                .ForMember(x => x.Cep, opt => opt.Ignore())
                .ForMember(x => x.MicroRegiao, opt => opt.Ignore())
                .ForMember(x => x.Endereco, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CidadeUpdateCommand, CidadeUpdateNotification>()
               .ForMember(x => x.Estado, opt => opt.Ignore())
               .ForMember(x => x.Cep, opt => opt.Ignore())
               .ForMember(x => x.MicroRegiao, opt => opt.Ignore())
               .ForMember(x => x.Endereco, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<CidadeDeleteCommand, CidadeDeleteNotification>()
               .ForMember(x => x.Estado, opt => opt.Ignore())
               .ForMember(x => x.Cep, opt => opt.Ignore())
               .ForMember(x => x.MicroRegiao, opt => opt.Ignore())
               .ForMember(x => x.Endereco, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Cliente

            CreateMap<ClienteCreateCommand, ClienteCreateNotification>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore())
                .ForMember(x => x.Vendas, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<ClienteUpdateCommand, ClienteUpdateNotification>()
               .ForMember(x => x.Agendamentos, opt => opt.Ignore())
               .ForMember(x => x.Vendas, opt => opt.Ignore())
               .ForMember(x => x.Pessoa, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<ClienteDeleteCommand, ClienteDeleteNotification>()
              .ForMember(x => x.Agendamentos, opt => opt.Ignore())
              .ForMember(x => x.Vendas, opt => opt.Ignore())
              .ForMember(x => x.Pessoa, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Empresa

            CreateMap<EmpresaCreateCommand, EmpresaCreateNotification>()
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVendas, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<EmpresaUpdateCommand, EmpresaUpdateNotification>()
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVendas, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<EmpresaDeleteCommand, EmpresaDeleteNotification>()
               .ForMember(x => x.Pessoa, opt => opt.Ignore())
               .ForMember(x => x.UnidadeVendas, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Endereco

            CreateMap<EnderecoCreateCommand, EnderecoCreateNotification>()
                .ForMember(x => x.Cidade, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<EnderecoUpdateCommand, EnderecoUpdateNotification>()
               .ForMember(x => x.Cidade, opt => opt.Ignore())
               .ForMember(x => x.Pessoa, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<EnderecoDeleteCommand, EnderecoDeleteNotification>()
              .ForMember(x => x.Cidade, opt => opt.Ignore())
              .ForMember(x => x.Pessoa, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Estado

            CreateMap<EstadoCreateCommand, EstadoCreateNotification>()
                .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
                .ForMember(x => x.Regiao, opt => opt.Ignore())
                .ForMember(x => x.Cidade, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<EstadoUpdateCommand, EstadoUpdateNotification>()
               .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
               .ForMember(x => x.Regiao, opt => opt.Ignore())
               .ForMember(x => x.Cidade, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<EstadoDeleteCommand, EstadoDeleteNotification>()
                .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
                .ForMember(x => x.Regiao, opt => opt.Ignore())
                .ForMember(x => x.Cidade, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Fornecedor

            CreateMap<FornecedorCreateCommand, FornecedorCreateNotification>()
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<FornecedorUpdateCommand, FornecedorCreateNotification>()
               .ForMember(x => x.Pessoa, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<FornecedorDeleteCommand, FornecedorDeleteNotification>()
             .ForMember(x => x.Pessoa, opt => opt.Ignore())
             .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Funcao

            CreateMap<FuncaoCreateCommand, FuncaoCreateNotification>()
                 .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<FuncaoUpdateCommand, FuncaoUpdateNotification>()
                 .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<FuncaoDeleteCommand, FuncaoDeleteNotification>()
                 .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region  FuncaoUsuario

            CreateMap<FuncaoUsuarioCreateCommand, FuncaoUsuarioCreateNotification>()
                .ForMember(x => x.Role, opt => opt.Ignore())
                .ForMember(x => x.User, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<FuncaoUsuarioUpdateCommand, FuncaoUsuarioUpdateNotification>()
                 .ForMember(x => x.Role, opt => opt.Ignore())
                 .ForMember(x => x.User, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<FuncaoUsuarioDeleteCommand, FuncaoUsuarioDeleteNotification>()
               .ForMember(x => x.Role, opt => opt.Ignore())
               .ForMember(x => x.User, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Funcionario

            CreateMap<FuncionarioCreateCommand, FuncionarioCreateNotification>()
               .ForMember(x => x.Atendentes, opt => opt.Ignore())
               .ForMember(x => x.Pessoa, opt => opt.Ignore())
               .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
               .ForMember(x => x.ResponsaveisServico, opt => opt.Ignore())
               .ForMember(x => x.Vendas, opt => opt.Ignore())
               .ForMember(x => x.Agendas, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<FuncionarioUpdateCommand, FuncionarioUpdateNotification>()
               .ForMember(x => x.Atendentes, opt => opt.Ignore())
               .ForMember(x => x.Pessoa, opt => opt.Ignore())
               .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
               .ForMember(x => x.ResponsaveisServico, opt => opt.Ignore())
               .ForMember(x => x.Vendas, opt => opt.Ignore())
               .ForMember(x => x.Agendas, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<FuncionarioDeleteCommand, FuncionarioDeleteNotification>()
               .ForMember(x => x.Atendentes, opt => opt.Ignore())
               .ForMember(x => x.Pessoa, opt => opt.Ignore())
               .ForMember(x => x.CargosFuncionario, opt => opt.Ignore())
               .ForMember(x => x.ResponsaveisServico, opt => opt.Ignore())
               .ForMember(x => x.Vendas, opt => opt.Ignore())
               .ForMember(x => x.Agendas, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region ItemVanda

            CreateMap<ItemVendaCreateCommand, ItemVendaCreateNotification>()
                .ForMember(x => x.Produto, opt => opt.Ignore())
                .ForMember(x => x.Venda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<ItemVendaUpdateCommand, ItemVendaUpdateNotification>()
               .ForMember(x => x.Produto, opt => opt.Ignore())
                .ForMember(x => x.Venda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<ItemVendaDeleteCommand, ItemVendaDeleteNotification>()
               .ForMember(x => x.Produto, opt => opt.Ignore())
                .ForMember(x => x.Venda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region MesoRegiao

            CreateMap<MesoRegiaoCreateCommand, MesoRegiaoCreateNotification>()
                .ForMember(x => x.Estado, opt => opt.Ignore())
                .ForMember(x => x.MicroRegiao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());


            CreateMap<MesoRegiaoUpdateCommand, MesoRegiaoUpdateNotification>()
                .ForMember(x => x.Estado, opt => opt.Ignore())
                .ForMember(x => x.MicroRegiao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<MesoRegiaoDeleteCommand, MesoRegiaoDeleteNotification>()
               .ForMember(x => x.Estado, opt => opt.Ignore())
                .ForMember(x => x.MicroRegiao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region MicroRegiao

            CreateMap<MicroRegiaoCreateCommand, MicroRegiaoCreateNotification>()
                .ForMember(x => x.Cidade, opt => opt.Ignore())
                .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<MicroRegiaoUpdateCommand, MicroRegiaoUpdateNotification>()
               .ForMember(x => x.Cidade, opt => opt.Ignore())
               .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<MicroRegiaoDeleteCommand, MicroRegiaoDeleteNotification>()
               .ForMember(x => x.Cidade, opt => opt.Ignore())
               .ForMember(x => x.MesoRegiao, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Motivo

            CreateMap<MotivoCreateCommand, MotivoCreateNotification>()
                .ForMember(x => x.Agenda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<MotivoUpdateCommand, MotivoUpdateNotification>()
               .ForMember(x => x.Agenda, opt => opt.Ignore())
               .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<MotivoDeleteCommand, MotivoDeleteNotification>()
              .ForMember(x => x.Agenda, opt => opt.Ignore())
              .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Pessoa

            CreateMap<PessoaCreateCommand, PessoaCreateNotification>()
                .ForMember(x => x.Endereco, opt => opt.Ignore())
                .ForMember(x => x.Usuario, opt => opt.Ignore())
                .ForMember(x => x.Cliente, opt => opt.Ignore())
                .ForMember(x => x.Fornecedor, opt => opt.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
                .ForMember(x => x.Empresa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<PessoaUpdateCommand, PessoaUpdateNotification>()
               .ForMember(x => x.Endereco, opt => opt.Ignore())
                .ForMember(x => x.Usuario, opt => opt.Ignore())
                .ForMember(x => x.Cliente, opt => opt.Ignore())
                .ForMember(x => x.Fornecedor, opt => opt.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
                .ForMember(x => x.Empresa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<PessoaDeleteCommand, PessoaDeleteNotification>()
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

            CreateMap<ProdutoCreateCommand, ProdutoCreateNotification>()
                .ForMember(x => x.Categoria, opt => opt.Ignore())
                .ForMember(x => x.ItemVendas, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<ProdutoUpdateCommand, ProdutoUpdateNotification>()
                .ForMember(x => x.Categoria, opt => opt.Ignore())
                .ForMember(x => x.ItemVendas, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<ProdutoDeleteCommand, ProdutoDeleteNotification>()
                .ForMember(x => x.Categoria, opt => opt.Ignore())
                .ForMember(x => x.ItemVendas, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Regiao

            CreateMap<RegiaoCreateCommand, RegiaoCreateNotification>()
                 .ForMember(x => x.Estados, opt => opt.Ignore())
                 .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<RegiaoUpdateCommand, RegiaoUpdateNotification>()
                .ForMember(x => x.Estados, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<RegiaoDeleteCommand, RegiaoDeleteNotification>()
                .ForMember(x => x.Estados, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Servico

            CreateMap<ServicoCreateCommand, ServicoCreateNotification>()
                .ForMember(x => x.UsuarioResponsavel, opt => opt.Ignore())
                .ForMember(x => x.UsuarioCriacao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<ServicoUpdateCommand, ServicoUpdateNotification>()
                .ForMember(x => x.UsuarioResponsavel, opt => opt.Ignore())
                .ForMember(x => x.UsuarioCriacao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<ServicoDeleteCommand, ServicoDeleteNotification>()
                .ForMember(x => x.UsuarioResponsavel, opt => opt.Ignore())
                .ForMember(x => x.UsuarioCriacao, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region UnidadeVenda

            CreateMap<UnidadeVendaCreateCommand, UnidadeVendaCreateNotification>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore())
                .ForMember(x => x.Agendas, opt => opt.Ignore())
                .ForMember(x => x.Empresa, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<UnidadeVendaUpdateCommand, UnidadeVendaUpdateNotification>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore())
                .ForMember(x => x.Agendas, opt => opt.Ignore())
                .ForMember(x => x.Empresa, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<UnidadeVendaDeleteCommand, UnidadeVendaDeleteNotification>()
               .ForMember(x => x.Agendamentos, opt => opt.Ignore())
                .ForMember(x => x.Agendas, opt => opt.Ignore())
                .ForMember(x => x.Empresa, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

            #region Usuario

            CreateMap<UsuarioCreateCommand, UsuarioCreateNotification>()
                .ForMember(x => x.ServicoResponsavel, opt => opt.Ignore())
                .ForMember(x => x.ServicoCriacao, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());


            CreateMap<UsuarioUpdateCommand, UsuarioUpdateNotification>()
                .ForMember(x => x.ServicoResponsavel, opt => opt.Ignore())
                .ForMember(x => x.ServicoCriacao, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());


            CreateMap<UsuarioDeleteCommand, UsuarioDeleteNotification>()
                .ForMember(x => x.ServicoResponsavel, opt => opt.Ignore())
                .ForMember(x => x.ServicoCriacao, opt => opt.Ignore())
                .ForMember(x => x.Pessoa, opt => opt.Ignore())
                .ForMember(x => x.FuncoesUsuarios, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());


            #endregion

            #region Venda

            CreateMap<VendaCreateCommand, VendaCreateNotification>()
                .ForMember(x => x.Cliente, opt => opt.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
                .ForMember(x => x.ItemVenda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<VendaUpdateCommand, VendaUpdateNotification>()
                .ForMember(x => x.Cliente, opt => opt.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
                .ForMember(x => x.ItemVenda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            CreateMap<VendaDeleteCommand, VendaDeleteNotification>()
                .ForMember(x => x.Cliente, opt => opt.Ignore())
                .ForMember(x => x.Funcionario, opt => opt.Ignore())
                .ForMember(x => x.UnidadeVenda, opt => opt.Ignore())
                .ForMember(x => x.ItemVenda, opt => opt.Ignore())
                .ForMember(x => x._Id, opt => opt.Ignore());

            #endregion

        }
    }
}
