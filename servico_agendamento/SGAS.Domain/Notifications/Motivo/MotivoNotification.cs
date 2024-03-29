using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("MOTIVO")]
    public class MotivoNotification : EventBase
    {
        [BsonElement("MOTI_ID")]
        public override int Id { get; set; }

        [BsonElement("MOTI_DESCRICAO")]
        public string Descricao { get; set; }

        [BsonElement("AGENDAS")]
        public virtual List<AgendaNotification> Agenda { get; set; }
    }
}
