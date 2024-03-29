using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("CARGO")]
    public class CargoNotification : EventBase
    {
        [BsonElement(elementName: "CARG_ID")]
        public override int Id { get; set; }

        [BsonElement(elementName: "CARG_DESCRICAO")]
        public string Descricao { get; set; }

        [BsonElement(elementName: "CARG_ATIVO")]
        public int Ativo { get; set; }

        [BsonElement(elementName: "CARGOS_FUNCIONARIOS")]
        public List<CargoFuncionarioNotification> CargosFuncionario { get; set; }

      

    }

    public static class CargoDomainToNotification
    {
        public static CargoNotification ToNotification(this Cargo domain)
        {
            var notification = new CargoNotification();

            return notification;
        }
    }
}
