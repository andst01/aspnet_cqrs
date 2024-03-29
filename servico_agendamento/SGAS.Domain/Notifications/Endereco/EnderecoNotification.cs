using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("ENDERECO")]
    public class EnderecoNotification : EventBase
    {
        [BsonElement(elementName: "ENDE_ID")]
        public override int Id { get; set; }

        [BsonElement(elementName: "ENDE_LOGRADOURO")]
        public string Logradouro { get; set; }

        [BsonElement(elementName: "ENDE_NUMERO")]
        public string Numero { get; set; }

        [BsonElement(elementName: "ENDE_BAIRRO")]
        public string Bairro { get; set; }

        [BsonElement(elementName: "ENDE_COMPLEMENTO")]
        public string Complemento { get; set; }

        [BsonElement(elementName: "ENDE_CEP")]
        public string Cep { get; set; }

        [BsonElement(elementName: "ENDE_ID_CIDADE")]
        public int IdCidade { get; set; }

        [BsonElement(elementName: "CIDADE")]
        public virtual CidadeNotification Cidade { get; set; }

        [BsonElement(elementName: "PESSOA")]
        public virtual PessoaCreateNotification Pessoa { get; set; }

        [BsonElement(elementName: "ENDE_ID_PESSOA")]
        public int IdPessoa { get; set; }


    }
}
