using MongoDB.Bson;
using MongoDB.Driver;
using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace SGAS.Infra.RepositoryQuery
{
    public class FuncionarioQueryRepository : RepositoryQueryBase<FuncionarioNotification>, IFuncionarioQueryRepository
    {
        public FuncionarioQueryRepository(IMongoDBContext context) : base(context)
        {
        }

        public void teste()
        {
           var criterion =  Builders<FuncionarioNotification>.Filter.Where(x => x.IdPessoa == 1);
           var cargoFuncionario = this._context.db.GetCollection<CargoFuncionarioNotification>("CARGO_FUNCIONARIO");


          var teste2 =  collection.Aggregate()
                .Match(x => x.Id == 0)
                .Lookup("CARGO_FUNCIONARIO", "FNCR_ID", "CGFN_ID_FUNCIONARIO", "CARGOS_FUNCIONARIOS")
                .Lookup("CARGO", "CARGOS_FUNCIONARIOS.CGFN_ID_CARGO", "CARG_ID", "CARGOS_FUNCIONARIOS.CARGO")
                .As<FuncionarioNotification>()
                .ToList();


            var teste3 = collection.Aggregate()
                .Match(criterion)
                .Lookup("CARGO_FUNCIONARIO", "FNCR_ID", "CGFN_ID_FUNCIONARIO", "CARGOS_FUNCIONARIOS")
                .As<FuncionarioNotification>()
                .ToList();
        }
    }
}
