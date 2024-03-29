using SGAS.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGAS.Domain.Utils;
using SGAS.Domain.Notifications;

namespace SGAS.Infra.Context
{
    public class MongoDBContext : IMongoDBContext
    {
       
        public IMongoDatabase db { get; set; }
        public IClientSessionHandle Session { get; set; }
        public MongoClient MongoClient { get; set; }
        private readonly List<Func<Task>> _commands;
        private readonly IConfiguration _configuration;

        public MongoDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            var client = new MongoClient(configuration["MongoDBConnection:ConnectionString"]);
            db = client.GetDatabase(configuration["MongoDBConnection:DataBaseName"]);

            #region criação de collections

            //GetCollection<AgendaNotification>(GetCollectionName(typeof(AgendaNotification))).InsertOne(new AgendaNotification());
            //GetCollection<CategoriaNotification>(GetCollectionName(typeof(CategoriaNotification))).InsertOne(new CategoriaNotification());
            //GetCollection<CargoNotification>(GetCollectionName(typeof(CargoNotification))).InsertOne(new CargoNotification());
            //GetCollection<CargoFuncionarioNotification>(GetCollectionName(typeof(CargoFuncionarioNotification))).InsertOne(new CargoFuncionarioNotification());
            //GetCollection<FuncionarioNotification>(GetCollectionName(typeof(FuncionarioNotification))).InsertOne(new FuncionarioNotification());
            //GetCollection<CepNotification>(GetCollectionName(typeof(CepNotification))).InsertOne(new CepNotification());
            //GetCollection<CidadeNotification>(GetCollectionName(typeof(CidadeNotification))).InsertOne(new CidadeNotification());
            //GetCollection<ClienteNotification>(GetCollectionName(typeof(ClienteNotification))).InsertOne(new ClienteNotification());
            //GetCollection<EmpresaNotification>(GetCollectionName(typeof(EmpresaNotification))).InsertOne(new EmpresaNotification());
            //GetCollection<EnderecoNotification>(GetCollectionName(typeof(EnderecoNotification))).InsertOne(new EnderecoNotification());
            //GetCollection<EstadoNotification>(GetCollectionName(typeof(EstadoNotification))).InsertOne(new EstadoNotification());
            //GetCollection<FornecedorNotification>(GetCollectionName(typeof(FornecedorNotification))).InsertOne(new FornecedorNotification());
            //GetCollection<FuncaoNotification>(GetCollectionName(typeof(FuncaoNotification))).InsertOne(new FuncaoNotification());
            //GetCollection<FuncaoUsuarioNotification>(GetCollectionName(typeof(FuncaoUsuarioNotification))).InsertOne(new FuncaoUsuarioNotification());
            //GetCollection<ItemVendaNotification>(GetCollectionName(typeof(ItemVendaNotification))).InsertOne(new ItemVendaNotification());
            //GetCollection<MesoRegiaoNotification>(GetCollectionName(typeof(MesoRegiaoNotification))).InsertOne(new MesoRegiaoNotification());
            //GetCollection<MicroRegiaoNotification>(GetCollectionName(typeof(MicroRegiaoNotification))).InsertOne(new MicroRegiaoNotification());
            //GetCollection<MotivoNotification>(GetCollectionName(typeof(MotivoNotification))).InsertOne(new MotivoNotification());
            //GetCollection<PessoaNotification>(GetCollectionName(typeof(PessoaNotification))).InsertOne(new PessoaNotification());
            //GetCollection<ProdutoNotification>(GetCollectionName(typeof(ProdutoNotification))).InsertOne(new ProdutoNotification());
            //GetCollection<RegiaoNotification>(GetCollectionName(typeof(RegiaoNotification))).InsertOne(new RegiaoNotification());
            //GetCollection<ServicoNotification>(GetCollectionName(typeof(ServicoNotification))).InsertOne(new ServicoNotification());
            //GetCollection<UnidadeVendaNotification>(GetCollectionName(typeof(UnidadeVendaNotification))).InsertOne(new UnidadeVendaNotification());
            //GetCollection<UsuarioNotification>(GetCollectionName(typeof(UsuarioNotification))).InsertOne(new UsuarioNotification());

            //GetCollection<UnidadeVendaNotification>(GetCollectionName(typeof(UnidadeVendaNotification))).InsertOne(new UnidadeVendaNotification());
           // GetCollection<CidadeNotification>(GetCollectionName(typeof(CidadeNotification))).InsertOne(new CidadeNotification());

            #endregion
        }


        public async Task<int> SaveChanges()
        {
            ConfigureMongo();

            using (Session = await MongoClient.StartSessionAsync())
            {
                Session.StartTransaction();

                var commandTasks = _commands.Select(c => c());

                await Task.WhenAll(commandTasks);

                await Session.CommitTransactionAsync();
            }

            return _commands.Count;
        }

        private void ConfigureMongo()
        {
            if (MongoClient != null)
            {
                return;
            }

            MongoClient = new MongoClient(_configuration["MongoDBConnection:ConnectionString"]);

            db = MongoClient.GetDatabase(_configuration["MongoDBConnection:DataBaseName"]);
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            ConfigureMongo();

            
            return db.GetCollection<T>(name);
        }

        public void Dispose()
        {
            Session?.Dispose();
            GC.SuppressFinalize(this);
        }

        public void AddCommand(Func<Task> func)
        {
            
            _commands.Add(func);
        }

        public string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                    typeof(BsonCollectionAttribute),
                    true)

                .FirstOrDefault())?.CollectionName;
        }
    }
}
