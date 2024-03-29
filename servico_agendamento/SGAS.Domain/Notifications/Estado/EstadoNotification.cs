using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("ESTADO")]
    public class EstadoNotification : EventBase
    {
        [BsonElement(elementName: "EST_ID")]
        public override int Id { get; set; }

        [BsonElement(elementName: "EST_SIGLA")]
        public string Sigla { get; set; }

        [BsonElement(elementName: "EST_NOME")]
        public string Nome { get; set; }

        [BsonElement(elementName: "EST_ID_REGIAO")]
        public int IdRegiao { get; set; }

        [BsonElement(elementName: "REGIAO")]
        public virtual RegiaoNotification Regiao { get; set; }

        [BsonElement(elementName: "CIDADES")]
        public virtual ICollection<CidadeNotification> Cidade { get; set; }

        [BsonElement(elementName: "MESOREGIOES")]
        public virtual ICollection<MesoRegiaoNotification> MesoRegiao { get; set; }
    }
}
