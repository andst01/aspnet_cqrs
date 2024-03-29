using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("CIDADE")]
    public class CidadeNotification : EventBase
    {
        [BsonElement(elementName: "CIDA_ID")]
        public override int Id { get; set; }

        [BsonElement(elementName: "CIDA_NOME")]
        public string Nome { get; set; }

        [BsonElement(elementName: "CIDA_ID_MICROREGIAO")]
        public int IdMicroRegiao { get; set; }

        [BsonElement(elementName: "CIDA_ID_ESTADO")]
        public int IdEstado { get; set; }

        [BsonElement(elementName: "ESTADO")]
        public virtual EstadoNotification Estado { get; set; }

        [BsonElement(elementName: "MICROREGIAO")]
        public virtual MicroRegiaoNotification MicroRegiao { get; set; }

        [BsonElement(elementName: "CEPS")]
        public virtual ICollection<CepNotification> Cep { get; set; }

        [BsonElement(elementName: "ENDERECOS")]
        public virtual ICollection<EnderecoNotification> Endereco { get; set; }
    }
}
