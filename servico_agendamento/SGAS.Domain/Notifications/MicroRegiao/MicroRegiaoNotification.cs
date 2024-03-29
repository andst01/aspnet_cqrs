using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("MICRO_REGIAO")]
    public class MicroRegiaoNotification : EventBase
    {
        [BsonElement("MCRG_ID")]
        public override int Id { get; set; }

        [BsonElement("MCRG_NOME")]
        public string Nome { get; set; }

        [BsonElement("MCRG_ID_REGIAO")]
        public int IdMesoRegiao { get; set; }

        [BsonElement("MESOREGIAO")]
        public virtual MesoRegiaoNotification MesoRegiao { get; set; }

        [BsonElement("CIDADES")]
        public virtual ICollection<CidadeNotification> Cidade { get; set; }

    }
}
