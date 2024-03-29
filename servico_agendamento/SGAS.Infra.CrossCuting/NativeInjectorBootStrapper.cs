using FluentValidation.Results;
using SGAS.Application;
using SGAS.Application.Interfaces;
using SGAS.Domain.Notifications;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;
using SGAS.Infra.Identity;
using SGAS.Infra.Repository;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Infra.RepositoryQuery;
using SGAS.Infra.RepositoryMongo.Base;
using SGAS.Domain.Interfaces.RepositoryMongo.Base;
using SGAS.Domain.Interfaces;
using SGAS.Application.Interfaces.Base;
using SGAS.Application.Base;
using SGAS.Application.Interfaces.Facade;
using SGAS.Application.Facades;
using SGAS.Domain.Interfaces.Mediator;
using SGAS.Infra.Mediator;

namespace SGAS.Infra.CrossCuting
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            #region Repositórios
            // Domain - Repository
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();
            services.AddScoped<IAgendaRepository, AgendaRepository>();
            services.AddScoped<ICargoFuncionarioRepository, CargoFuncionarioRepository>();
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ICepRepository, CepRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IFuncaoRepository, FuncaoRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IFuncaoUsuarioRepository, FuncaoUsuarioRepository>();
            services.AddScoped<IHistoricoEventoRepository, HistoricoEventoRepository>();
            services.AddScoped<IItemVendaRepository, ItemVendaRepository>();
            services.AddScoped<IMesoRegiaoRepository, MesoRegiaoRepository>();
            services.AddScoped<IMicroRegiaoRepository, MicroRegiaoRepository>();
            services.AddScoped<IMotivoRepository, MotivoRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IRegiaoRepository, RegiaoRepository>();
            services.AddScoped<IServicoRepository, ServicoRepository>();
            services.AddScoped<IUnidadeVendaRepository, UnidadeVendaRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IVendaRepository, VendaRepository>();

            /// RepositoryQuery - MongoDB

            services.AddScoped<IMongoDBContext, MongoDBContext>();
            services.AddScoped<MongoDBContext>();
            services.AddScoped(typeof(IRepositoryQueryBase<>), typeof(RepositoryQueryBase<>));
            services.AddScoped<IAgendamentoQueryRepository, AgendamentoQueryRepository>();
            services.AddScoped<IAgendaQueryRepository, AgendaQueryRepository>();
            services.AddScoped<ICargoFuncionarioQueryRepository, CargoFuncionarioQueryRepository>();
            services.AddScoped<ICargoQueryRepository, CargoQueryRepository>();
            services.AddScoped<ICategoriaQueryRepository, CategoriaQueryRepository>();
            services.AddScoped<ICepQueryRepository, CepQueryRepository>();
            services.AddScoped<ICidadeQueryRepository, CidadeQueryRepository>();
            services.AddScoped<IClienteQueryRepository, ClienteQueryRepository>();
            services.AddScoped<IEmpresaQueryRepository, EmpresaQueryRepository>();
            services.AddScoped<IEnderecoQueryRepository, EnderecoQueryRepository>();
            services.AddScoped<IEstadoQueryRepository, EstadoQueryRepository>();
            services.AddScoped<IFornecedorQueryRepository, FornecedorQueryRepository>();
            services.AddScoped<IFuncaoQueryRepository, FuncaoQueryRepository>();
            services.AddScoped<IFuncionarioQueryRepository, FuncionarioQueryRepository>();
            services.AddScoped<IFuncaoUsuarioQueryRepository, FuncaoUsuarioQueryRepository>();
            //  services.AddScoped<IHistoricoEventoQueryRepository, HistoricoEventoQueryRepository>();
            services.AddScoped<IItemVendaQueryRepository, ItemVendaQueryRepository>();
            services.AddScoped<IMesoRegiaoQueryRepository, MesoRegiaoQueryRepository>();
            services.AddScoped<IMicroRegiaoQueryRepository, MicroRegiaoQueryRepository>();
            services.AddScoped<IMotivoQueryRepository, MotivoQueryRepository>();
            services.AddScoped<IPessoaQueryRepository, PessoaQueryRepository>();
            services.AddScoped<IProdutoQueryRepository, ProdutoQueryRepository>();
            services.AddScoped<IRegiaoQueryRepository, RegiaoQueryRepository>();
            services.AddScoped<IServicoQueryRepository, ServicoQueryRepository>();
            services.AddScoped<IUnidadeVendaQueryRepository, UnidadeVendaQueryRepository>();
            services.AddScoped<IUsuarioQueryRepository, UsuarioQueryRepository>();
            services.AddScoped<IVendaQueryRepository, VendaQueryRepository>();

            #endregion

            #region Application
            //Application
            services.AddScoped<IDadosIbgeFacade, DadosIbgeFacade>();

           // services.AddScoped(typeof(IApplicationBase<>), typeof(ApplicationBase<>));
            services.AddScoped<IAgendamentoApp, AgendamentoApp>();
            services.AddScoped<IAgendaApp, AgendaApp>();
            services.AddScoped<ICargoFuncionarioApp, CargoFuncionarioApp>();
            services.AddScoped<ICargoApp, CargoApp>();
            services.AddScoped<ICategoriaApp, CategoriaApp>();
            services.AddScoped<ICepApp, CepApp>();
            services.AddScoped<ICidadeApp, CidadeApp>();
            services.AddScoped<IClienteApp, ClienteApp>();
            services.AddScoped<IEmpresaApp, EmpresaApp>();
            services.AddScoped<IEnderecoApp, EnderecoApp>();
            services.AddScoped<IEstadoApp, EstadoApp>();
            services.AddScoped<IFornecedorApp, FornecedorApp>();
            services.AddScoped<IFuncaoApp, FuncaoApp>();
            services.AddScoped<IFuncaoUsuarioApp, FuncaoUsuarioApp>();
            services.AddScoped<IFuncionarioApp, FuncionarioApp>();
            //  services.AddScoped<IHistoricoEventoApp, HistoricoEventoApp>();
            services.AddScoped<IItemVendaApp, ItemVendaApp>();
            services.AddScoped<IMesoRegiaoApp, MesoRegiaoApp>();
            services.AddScoped<IMicroRegiaoApp, MicroRegiaoApp>();
            services.AddScoped<IMotivoApp, MotivoApp>();
            services.AddScoped<IPessoaApp, PessoaApp>();
            services.AddScoped<IProdutoApp, ProdutoApp>();
            services.AddScoped<IRegiaoApp, RegiaoApp>();
            services.AddScoped<IServicoApp, ServicoApp>();
            services.AddScoped<IUnidadeVendaApp, UnidadeVendaApp>();
            services.AddScoped<IUsuarioApp, UsuarioApp>();
            services.AddScoped<IVendaApp, VendaApp>();

            #endregion

            #region Notifications
            // Domain - Events
            services.AddScoped<INotificationHandler<AgendamentoCreateNotification>, AgendamentoNotificationHandler>();
            services.AddScoped<INotificationHandler<AgendamentoUpdateNotification>, AgendamentoNotificationHandler>();
            services.AddScoped<INotificationHandler<AgendamentoDeleteNotification>, AgendamentoNotificationHandler>();

            services.AddScoped<INotificationHandler<AgendaCreateNotification>, AgendaNotificationHandler>();
            services.AddScoped<INotificationHandler<AgendaUpdateNotification>, AgendaNotificationHandler>();
            services.AddScoped<INotificationHandler<AgendaDeleteNotification>, AgendaNotificationHandler>();

            services.AddScoped<INotificationHandler<CargoCreateNotification>, CargoNotificationHandler>();
            services.AddScoped<INotificationHandler<CargoUpdateNotification>, CargoNotificationHandler>();
            services.AddScoped<INotificationHandler<CargoDeleteNotification>, CargoNotificationHandler>();

            services.AddScoped<INotificationHandler<CargoFuncionarioCreateNotification>, CargoFuncionarioNotificationHandler>();
            services.AddScoped<INotificationHandler<CargoFuncionarioUpdateNotification>, CargoFuncionarioNotificationHandler>();
            services.AddScoped<INotificationHandler<CargoFuncionarioDeleteNotification>, CargoFuncionarioNotificationHandler>();

            services.AddScoped<INotificationHandler<CategoriaCreateNotification>, CategoriaNotificationHandler>();
            services.AddScoped<INotificationHandler<CategoriaUpdateNotification>, CategoriaNotificationHandler>();
            services.AddScoped<INotificationHandler<CategoriaDeleteNotification>, CategoriaNotificationHandler>();

            services.AddScoped<INotificationHandler<CepCreateNotification>, CepNotificationHandler>();
            services.AddScoped<INotificationHandler<CepUpdateNotification>, CepNotificationHandler>();
            services.AddScoped<INotificationHandler<CepDeleteNotification>, CepNotificationHandler>();

            services.AddScoped<INotificationHandler<CidadeCreateNotification>, CidadeNotificationHandler>();
            services.AddScoped<INotificationHandler<CidadeUpdateNotification>, CidadeNotificationHandler>();
            services.AddScoped<INotificationHandler<CidadeDeleteNotification>, CidadeNotificationHandler>();

            services.AddScoped<INotificationHandler<EmpresaCreateNotification>, EmpresaNotificationHandler>();
            services.AddScoped<INotificationHandler<EmpresaUpdateNotification>, EmpresaNotificationHandler>();
            services.AddScoped<INotificationHandler<EmpresaDeleteNotification>, EmpresaNotificationHandler>();

            services.AddScoped<INotificationHandler<EnderecoCreateNotification>, EnderecoNotificationHandler>();
            services.AddScoped<INotificationHandler<EnderecoUpdateNotification>, EnderecoNotificationHandler>();
            services.AddScoped<INotificationHandler<EnderecoDeleteNotification>, EnderecoNotificationHandler>();

            services.AddScoped<INotificationHandler<EstadoCreateNotification>, EstadoNotificationHandler>();
            services.AddScoped<INotificationHandler<EstadoUpdateNotification>, EstadoNotificationHandler>();
            services.AddScoped<INotificationHandler<EstadoDeleteNotification>, EstadoNotificationHandler>();

            services.AddScoped<INotificationHandler<FornecedorCreateNotification>, FornecedorNotificationHandler>();
            services.AddScoped<INotificationHandler<FornecedorUpdateNotification>, FornecedorNotificationHandler>();
            services.AddScoped<INotificationHandler<FornecedorDeleteNotification>, FornecedorNotificationHandler>();

            services.AddScoped<INotificationHandler<FuncaoCreateNotification>, FuncaoNotificationHandler>();
            services.AddScoped<INotificationHandler<FuncaoUpdateNotification>, FuncaoNotificationHandler>();
            services.AddScoped<INotificationHandler<FuncaoDeleteNotification>, FuncaoNotificationHandler>();

            services.AddScoped<INotificationHandler<FuncaoUsuarioCreateNotification>, FuncaoUsuarioNotificationHandler>();
            services.AddScoped<INotificationHandler<FuncaoUsuarioUpdateNotification>, FuncaoUsuarioNotificationHandler>();
            services.AddScoped<INotificationHandler<FuncaoUsuarioDeleteNotification>, FuncaoUsuarioNotificationHandler>();

            services.AddScoped<INotificationHandler<FuncionarioCreateNotification>, FuncionarioNotificationHandler>();
            services.AddScoped<INotificationHandler<FuncionarioUpdateNotification>, FuncionarioNotificationHandler>();
            services.AddScoped<INotificationHandler<FuncionarioDeleteNotification>, FuncionarioNotificationHandler>();

            services.AddScoped<INotificationHandler<ItemVendaCreateNotification>, ItemVendaNotificationHandler>();
            services.AddScoped<INotificationHandler<ItemVendaUpdateNotification>, ItemVendaNotificationHandler>();
            services.AddScoped<INotificationHandler<ItemVendaDeleteNotification>, ItemVendaNotificationHandler>();

            services.AddScoped<INotificationHandler<MesoRegiaoCreateNotification>, MesoRegiaoNotificationHandler>();
            services.AddScoped<INotificationHandler<MesoRegiaoUpdateNotification>, MesoRegiaoNotificationHandler>();
            services.AddScoped<INotificationHandler<MesoRegiaoDeleteNotification>, MesoRegiaoNotificationHandler>();

            services.AddScoped<INotificationHandler<MicroRegiaoCreateNotification>, MicroRegiaoNotificationHandler>();
            services.AddScoped<INotificationHandler<MicroRegiaoUpdateNotification>, MicroRegiaoNotificationHandler>();
            services.AddScoped<INotificationHandler<MicroRegiaoDeleteNotification>, MicroRegiaoNotificationHandler>();

            services.AddScoped<INotificationHandler<MotivoCreateNotification>, MotivoNotificationHandler>();
            services.AddScoped<INotificationHandler<MotivoUpdateNotification>, MotivoNotificationHandler>();
            services.AddScoped<INotificationHandler<MotivoDeleteNotification>, MotivoNotificationHandler>();

            services.AddScoped<INotificationHandler<PessoaCreateNotification>, PessoaNotificationHandler>();
            services.AddScoped<INotificationHandler<PessoaUpdateNotification>, PessoaNotificationHandler>();
            services.AddScoped<INotificationHandler<PessoaDeleteNotification>, PessoaNotificationHandler>();

            services.AddScoped<INotificationHandler<ProdutoCreateNotification>, ProdutoNotificationHandler>();
            services.AddScoped<INotificationHandler<ProdutoUpdateNotification>, ProdutoNotificationHandler>();
            services.AddScoped<INotificationHandler<ProdutoDeleteNotification>, ProdutoNotificationHandler>();

            services.AddScoped<INotificationHandler<RegiaoCreateNotification>, RegiaoNotificationHandler>();
            services.AddScoped<INotificationHandler<RegiaoUpdateNotification>, RegiaoNotificationHandler>();
            services.AddScoped<INotificationHandler<RegiaoDeleteNotification>, RegiaoNotificationHandler>();

            services.AddScoped<INotificationHandler<ServicoCreateNotification>, ServicoNotificationHandler>();
            services.AddScoped<INotificationHandler<ServicoUpdateNotification>, ServicoNotificationHandler>();
            services.AddScoped<INotificationHandler<ServicoDeleteNotification>, ServicoNotificationHandler>();

            services.AddScoped<INotificationHandler<UnidadeVendaCreateNotification>, UnidadeVendaNotificationHandler>();
            services.AddScoped<INotificationHandler<UnidadeVendaUpdateNotification>, UnidadeVendaNotificationHandler>();
            services.AddScoped<INotificationHandler<UnidadeVendaDeleteNotification>, UnidadeVendaNotificationHandler>();

            services.AddScoped<INotificationHandler<VendaCreateNotification>, VendaNotificationHandler>();
            services.AddScoped<INotificationHandler<VendaUpdateNotification>, VendaNotificationHandler>();
            services.AddScoped<INotificationHandler<VendaDeleteNotification>, VendaNotificationHandler>();

            #endregion

            #region Command

            services.AddScoped<IRequestHandler<AgendamentoCreateCommand, Agendamento>, AgendamentoCommandHandler>();
            services.AddScoped<IRequestHandler<AgendamentoUpdateCommand, Agendamento>, AgendamentoCommandHandler>();
            services.AddScoped<IRequestHandler<AgendamentoDeleteCommand, ValidationResult>, AgendamentoCommandHandler>();

            services.AddScoped<IRequestHandler<AgendaCreateCommand, Agenda>, AgendaCommandHandler>();
            services.AddScoped<IRequestHandler<AgendaUpdateCommand, Agenda>, AgendaCommandHandler>();
            services.AddScoped<IRequestHandler<AgendaDeleteCommand, ValidationResult>, AgendaCommandHandler>();

            services.AddScoped<IRequestHandler<CargoCreateCommand, Cargo>, CargoCommandHandler>();
            services.AddScoped<IRequestHandler<CargoUpdateCommand, Cargo>, CargoCommandHandler>();
            services.AddScoped<IRequestHandler<CargoDeleteCommand, ValidationResult>, CargoCommandHandler>();

            services.AddScoped<IRequestHandler<CargoFuncionarioCreateCommand, CargoFuncionario>, CargoFuncionarioCommandHandler>();
            services.AddScoped<IRequestHandler<CargoFuncionarioUpdateCommand, CargoFuncionario>, CargoFuncionarioCommandHandler>();
            services.AddScoped<IRequestHandler<CargoFuncionarioDeleteCommand, ValidationResult>, CargoFuncionarioCommandHandler>();

            services.AddScoped<IRequestHandler<CategoriaCreateCommand, Categoria>, CategoriaCommandHandler>();
            services.AddScoped<IRequestHandler<CategoriaUpdateCommand, Categoria>, CategoriaCommandHandler>();
            services.AddScoped<IRequestHandler<CategoriaDeleteCommand, ValidationResult>, CategoriaCommandHandler>();

            services.AddScoped<IRequestHandler<CepCreateCommand, Cep>, CepCommandHandler>();
            services.AddScoped<IRequestHandler<CepUpdateCommand, Cep>, CepCommandHandler>();
            services.AddScoped<IRequestHandler<CepDeleteCommand, ValidationResult>, CepCommandHandler>();

            services.AddScoped<IRequestHandler<CidadeCreateCommand, Cidade>, CidadeCommandHandler>();
            services.AddScoped<IRequestHandler<CidadeUpdateCommand, Cidade>, CidadeCommandHandler>();
            services.AddScoped<IRequestHandler<CidadeDeleteCommand, ValidationResult>, CidadeCommandHandler>();

            services.AddScoped<IRequestHandler<EmpresaCreateCommand, Empresa>, EmpresaCommandHandler>();
            services.AddScoped<IRequestHandler<EmpresaUpdateCommand, Empresa>, EmpresaCommandHandler>();
            services.AddScoped<IRequestHandler<EmpresaDeleteCommand, ValidationResult>, EmpresaCommandHandler>();

            services.AddScoped<IRequestHandler<EnderecoCreateCommand, Endereco>, EnderecoCommandHandler>();
            services.AddScoped<IRequestHandler<EnderecoUpdateCommand, Endereco>, EnderecoCommandHandler>();
            services.AddScoped<IRequestHandler<EnderecoDeleteCommand, ValidationResult>, EnderecoCommandHandler>();

            services.AddScoped<IRequestHandler<EstadoCreateCommand, Estado>, EstadoCommandHandler>();
            services.AddScoped<IRequestHandler<EstadoUpdateCommand, Estado>, EstadoCommandHandler>();
            services.AddScoped<IRequestHandler<EstadoDeleteCommand, ValidationResult>, EstadoCommandHandler>();

            services.AddScoped<IRequestHandler<FornecedorCreateCommand, Fornecedor>, FornecedorCommandHandler>();
            services.AddScoped<IRequestHandler<FornecedorUpdateCommand, Fornecedor>, FornecedorCommandHandler>();
            services.AddScoped<IRequestHandler<FornecedorDeleteCommand, ValidationResult>, FornecedorCommandHandler>();

            services.AddScoped<IRequestHandler<FuncaoCreateCommand, Funcao>, FuncaoCommandHandler>();
            services.AddScoped<IRequestHandler<FuncaoUpdateCommand, Funcao>, FuncaoCommandHandler>();
            services.AddScoped<IRequestHandler<FuncaoDeleteCommand, ValidationResult>, FuncaoCommandHandler>();

            services.AddScoped<IRequestHandler<FuncaoUsuarioCreateCommand, FuncaoUsuario>, FuncaoUsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<FuncaoUsuarioUpdateCommand, FuncaoUsuario>, FuncaoUsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<FuncaoUsuarioDeleteCommand, ValidationResult>, FuncaoUsuarioCommandHandler>();

            services.AddScoped<IRequestHandler<FuncionarioCreateCommand, Funcionario>, FuncionarioCommandHandler>();
            services.AddScoped<IRequestHandler<FuncionarioUpdateCommand, Funcionario>, FuncionarioCommandHandler>();
            services.AddScoped<IRequestHandler<FuncionarioDeleteCommand, ValidationResult>, FuncionarioCommandHandler>();

            services.AddScoped<IRequestHandler<ItemVendaCreateCommand, ItemVenda>, ItemVendaCommandHandler>();
            services.AddScoped<IRequestHandler<ItemVendaUpdateCommand, ItemVenda>, ItemVendaCommandHandler>();
            services.AddScoped<IRequestHandler<ItemVendaDeleteCommand, ValidationResult>, ItemVendaCommandHandler>();

            services.AddScoped<IRequestHandler<MesoRegiaoCreateCommand, MesoRegiao>, MesoRegiaoCommandHandler>();
            services.AddScoped<IRequestHandler<MesoRegiaoUpdateCommand, MesoRegiao>, MesoRegiaoCommandHandler>();
            services.AddScoped<IRequestHandler<MesoRegiaoDeleteCommand, ValidationResult>, MesoRegiaoCommandHandler>();

            services.AddScoped<IRequestHandler<MicroRegiaoCreateCommand, MicroRegiao>, MicroRegiaoCommandHandler>();
            services.AddScoped<IRequestHandler<MicroRegiaoUpdateCommand, MicroRegiao>, MicroRegiaoCommandHandler>();
            services.AddScoped<IRequestHandler<MicroRegiaoDeleteCommand, ValidationResult>, MicroRegiaoCommandHandler>();

            services.AddScoped<IRequestHandler<MotivoCreateCommand, Motivo>, MotivoCommandHandler>();
            services.AddScoped<IRequestHandler<MotivoUpdateCommand, Motivo>, MotivoCommandHandler>();
            services.AddScoped<IRequestHandler<MotivoDeleteCommand, ValidationResult>, MotivoCommandHandler>();

            services.AddScoped<IRequestHandler<PessoaCreateCommand, Pessoa>, PessoaCommandHandler>();
            services.AddScoped<IRequestHandler<PessoaUpdateCommand, Pessoa>, PessoaCommandHandler>();
            services.AddScoped<IRequestHandler<PessoaDeleteCommand, ValidationResult>, PessoaCommandHandler>();

            services.AddScoped<IRequestHandler<ProdutoCreateCommand, Produto>, ProdutoCommandHandler>();
            services.AddScoped<IRequestHandler<ProdutoUpdateCommand, Produto>, ProdutoCommandHandler>();
            services.AddScoped<IRequestHandler<ProdutoDeleteCommand, ValidationResult>, ProdutoCommandHandler>();

            services.AddScoped<IRequestHandler<RegiaoCreateCommand, Regiao>, RegiaoCommandHandler>();
            services.AddScoped<IRequestHandler<RegiaoUpdateCommand, Regiao>, RegiaoCommandHandler>();
            services.AddScoped<IRequestHandler<RegiaoDeleteCommand, ValidationResult>, RegiaoCommandHandler>();

            services.AddScoped<IRequestHandler<ServicoCreateCommand, Servico>, ServicoCommandHandler>();
            services.AddScoped<IRequestHandler<ServicoUpdateCommand, Servico>, ServicoCommandHandler>();
            services.AddScoped<IRequestHandler<ServicoDeleteCommand, ValidationResult>, ServicoCommandHandler>();

            services.AddScoped<IRequestHandler<UnidadeVendaCreateCommand, UnidadeVenda>, UnidadeVendaCommandHandler>();
            services.AddScoped<IRequestHandler<UnidadeVendaUpdateCommand, UnidadeVenda>, UnidadeVendaCommandHandler>();
            services.AddScoped<IRequestHandler<UnidadeVendaDeleteCommand, ValidationResult>, UnidadeVendaCommandHandler>();

            services.AddScoped<IRequestHandler<VendaCreateCommand, Venda>, VendaCommandHandler>();
            services.AddScoped<IRequestHandler<VendaUpdateCommand, Venda>, VendaCommandHandler>();
            services.AddScoped<IRequestHandler<VendaDeleteCommand, ValidationResult>, VendaCommandHandler>();


            #endregion

            services.AddScoped<IUser, DadosUsuario>();
            services.AddScoped<SGASContext>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
            services.AddHttpContextAccessor();
            services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();

            

        }
    }
}
