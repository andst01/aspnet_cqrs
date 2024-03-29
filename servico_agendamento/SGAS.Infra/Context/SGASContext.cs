using SGAS.Domain.Entity;
using System.Threading.Tasks;
using SGAS.Domain.Notifications;
using System.Linq;
using FluentValidation.Results;
using SGAS.Infra.Mappings;
using System.Collections.Generic;
using System;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Data.SqlClient;
using System.IO;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
//using MongoDB.EntityFrameworkCore.Extensions;

namespace SGAS.Infra.Context
{
    public class SGASContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                //.UseLazyLoadingProxies()
                .UseSqlServer(connectionString);

           
        }

        protected IConfiguration _configuration
        {
            get
            {
                return new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                                 .AddJsonFile("appsettings.Development.json").Build();
            }
        }

        public IDbConnection OpenConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("DefaultConnectionString"));
        }

        public  DbSet<Agenda> Agenda { get; set; }
        public  DbSet<Agendamento> Agendamento { get; set; }
        public  DbSet<CargoFuncionario> CargoFuncionario { get; set; }
        public  DbSet<Cargo> Cargo { get; set; }
        public  DbSet<Categoria> Categoria { get; set; }
        public  DbSet<Cep> Cep { get; set; }
        public  DbSet<Cidade> Cidade { get; set; }
        public  DbSet<Cliente> Cliente { get; set; }
        public  DbSet<Empresa> Empresa { get; set; }
        public DbSet<Endereco> Endereco { get; set; } 
        public  DbSet<Estado> Estado { get; set; }
        public  DbSet<Fornecedor> Fornecedor { get; set; }
        public  DbSet<Funcao> Funcao { get; set; }
        public  DbSet<FuncaoUsuario> FuncaoUsuario { get; set; }
        public  DbSet<Funcionario> Funcionario { get; set; }
        public  DbSet<HistoricoEvento> HistoricoEventos { get; set; }
        public  DbSet<ItemVenda> ItemVenda { get; set; }
        public  DbSet<MesoRegiao> MesoRegiao { get; set; }
        public  DbSet<MicroRegiao> MicroRegiao { get; set; }
        public  DbSet<Motivo> Motivo { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public  DbSet<Produto> Produto { get; set; }
        public  DbSet<Regiao> Regiao { get; set; }
        public  DbSet<Servico> Servico { get; set; }
        public  DbSet<UnidadeVenda> UnidadeVenda { get; set; }
        public  DbSet<Usuario> Usuario { get; set; }
        public  DbSet<Venda> Venda { get; set; }




        public async Task<bool> Commit()
        {

            var listaHistoricoEntry = await OnBeforePublishEvent();
            var saveChanges = await this.SaveChangesAsync();

            if (saveChanges == 0) return false;
           
            await OnAfterSaveChangesAsync(listaHistoricoEntry);

        
            return saveChanges > 1;
        }

      

        private async Task<Tuple<List<HistoricoEvento>, List<HistoricoEventoEntry>>> OnBeforePublishEvent()
        {

            var historicoEventosEntry = new List<HistoricoEventoEntry>();
            var historicoEventos = new List<HistoricoEvento>();

            this.ChangeTracker.DetectChanges();

            foreach (var entry in this.ChangeTracker.Entries())
            {

                //bool teste = true;
                if (entry.Entity is HistoricoEvento || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                    continue;

                var auditEntry = new HistoricoEventoEntry(entry);

                //entry.Members
                auditEntry.NomeTabela = entry.Metadata.GetTableName(); //.Relational().TableName; // EF Core 3.1: entry.Metadata.GetTableName();
                historicoEventosEntry.Add(auditEntry);

                foreach (var property in entry.Properties)
                {

                    auditEntry.TemporaryProperties = entry.Properties.Where(p => p.IsTemporary).ToList();

                    string propertyName = property.Metadata.GetColumnName();

                    if (property.Metadata.IsKey())
                    {
                        //auditEntry.ValoresAntigos[]
                        if (entry.State == EntityState.Added)
                            auditEntry.ValoresChaves[propertyName] = 0;
                        else
                            auditEntry.ValoresChaves[propertyName] = property.CurrentValue;
                        continue;
                    }


                    //auditEntry.CodigoUsuario = int.Parse(.Claims.FirstOrDefault(x => x.Type == "codigo_usuario")?.Value);
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            auditEntry.ValoresNovos[propertyName] = property.CurrentValue;
                            //auditEntry.ValoresAntigos[propertyName] = " ";
                            auditEntry.TipoOperacao = "I";
                            break;

                        case EntityState.Deleted:
                            auditEntry.ValoresAntigos[propertyName] = property.OriginalValue;
                            auditEntry.ValoresNovos[propertyName] = " ";
                            auditEntry.TipoOperacao = "E";
                            break;

                        case EntityState.Modified:
                            if (property.IsModified)
                            {
                                auditEntry.ValoresAntigos[propertyName] = property.OriginalValue;
                                auditEntry.ValoresNovos[propertyName] = property.CurrentValue;
                                auditEntry.TipoOperacao = "A";
                            }
                            break;
                    }
                }


            }

            foreach (var auditEntry in historicoEventosEntry)
            {
                var historicoEvento = auditEntry.ToHistoricoEvento();

                historicoEventos.Add(historicoEvento);
                HistoricoEventos.Add(historicoEvento);
            }


            var response = new Tuple<List<HistoricoEvento>, List<HistoricoEventoEntry>>(historicoEventos, historicoEventosEntry);

            return response;


        }

        private Task OnAfterSaveChangesAsync(Tuple<List<HistoricoEvento>, List<HistoricoEventoEntry>> tuplaHistoricos)
        {
            if (tuplaHistoricos.Item2 == null || tuplaHistoricos.Item2.Count == 0)
                return Task.CompletedTask;

           

            // For each temporary property in each audit entry - update the value in the audit entry to the actual (generated) value
            foreach (var entry in tuplaHistoricos.Item2)
            {
                var entidade = tuplaHistoricos.Item1
                        .Where(x => x.NomeTabela.ToUpper() == entry.NomeTabela.ToUpper() && x.TipoOperacao == "I")
                        .FirstOrDefault();

               

                if (entidade != null)
                {
                    var updateHistorico = new HistoricoEvento();

                    // ultimo teste
                    var objeto = this.Set<HistoricoEvento>().Find(entidade.Id);

                    // ultimo teste
                    this.Set<HistoricoEvento>().Attach(objeto);

                    int Id = entidade.Id;

                    foreach (var prop in entry.TemporaryProperties)
                    {

                        string propertyName = prop.Metadata.GetColumnName();

                        if (prop.Metadata.IsKey())
                        {
                            // deu certo
                            entry.ValoresChaves[propertyName] = prop.CurrentValue;
                        }

                        // deu certo
                        //entidade.ValoresChaves = Newtonsoft.Json.JsonConvert.SerializeObject(entry.ValoresChaves);

                        EntityEntry entityEntry = this.Entry(objeto);
                        entityEntry.Properties.Where(x => x.Metadata.IsKey());
                        // objeto = entry.ToHistoricoEventoUpdate(Id);

                        updateHistorico = entry.ToHistoricoEventoUpdate(Id);


                    }

                    this.Entry(objeto).CurrentValues.SetValues(updateHistorico);
                    this.Entry(objeto).State = EntityState.Modified;
                    // this.Set<HistoricoEvento>().Update(objeto);
                   

                    // deu certo
                    //this.Set<HistoricoEvento>().Update(entidade);
                   

                    this.SaveChanges();
                }
                
            }

            return Task.CompletedTask;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<EventBase>();

            // base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AgendaMap());
            modelBuilder.ApplyConfiguration(new AgendamentoMap());
            modelBuilder.ApplyConfiguration(new CargoMap());
            modelBuilder.ApplyConfiguration(new CargoFuncionarioMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new CepMap());
            modelBuilder.ApplyConfiguration(new CidadeMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new EstadoMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new FuncaoMap());
            modelBuilder.ApplyConfiguration(new FuncaoUsuarioMap());
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new HistoricoEventoMap());
            modelBuilder.ApplyConfiguration(new ItemVendaMap());
            modelBuilder.ApplyConfiguration(new MesoRegiaoMap());
            modelBuilder.ApplyConfiguration(new MicroRegiaoMap());
            modelBuilder.ApplyConfiguration(new MotivoMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new RegiaoMap());
            modelBuilder.ApplyConfiguration(new ServicoMap());
            modelBuilder.ApplyConfiguration(new UnidadeVendaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new VendaMap());


          


        }

        
    }


}
