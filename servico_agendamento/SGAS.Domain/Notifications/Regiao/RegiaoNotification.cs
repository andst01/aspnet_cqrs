using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("REGIAO")]
    public class RegiaoNotification : EventBase
    {
        [BsonElement("REGI_ID")]
        public override int Id { get; set; }

        [BsonElement("REGI_SIGLA")]
        public string Sigla { get; set; }

        [BsonElement("REGI_NOME")]
        public string Nome { get; set; }

        [BsonElement("ESTADOS")]
        public virtual ICollection<EstadoNotification> Estados { get; set; }
    }
}
