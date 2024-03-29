using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("MESO_REGIAO")]
    public class MesoRegiaoNotification : EventBase
    {
        [BsonElement("MSRG_ID")]
        public override int Id { get; set; }

        [BsonElement("MSRG_NOME")]
        public string Nome { get; set; }

        [BsonElement("MSRG_ID_ESTADO")]
        public int IdEstado { get; set; }

        [BsonElement("ESTADO")]
        public virtual EstadoNotification Estado { get; set; }

        [BsonElement("MICROREGIAO")]
        public virtual ICollection<MicroRegiaoNotification> MicroRegiao { get; set; }

    }
}
