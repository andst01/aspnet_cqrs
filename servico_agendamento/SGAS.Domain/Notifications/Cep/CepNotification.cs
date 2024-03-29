using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("CEP")]
    public class CepNotification : EventBase
    {
        [BsonElement(elementName:"CEP_ID")]
        public override int Id { get; set; }

        [BsonElement(elementName: "CEP_NUMERO")]
        public string NumeroCep { get; set; }

        [BsonElement(elementName: "CEP_LOGRADOURO")]
        public string Logradouro { get; set; }

        [BsonElement(elementName: "CEP_COMPLEMENTO")]
        public string Complemento { get; set; }

        [BsonElement(elementName: "CEP_ID_CIDADE")]
        public int IdCidade { get; set; }

        [BsonElement(elementName: "CEP_LOCALIDADE")]
        public string Localidade { get; set; }

        [BsonElement(elementName: "CEP_UF")]
        public string Uf { get; set; }

        [BsonElement(elementName: "CEP_POSSUI_CADASTRO")]
        public bool EhCadastroSistema { get; set; }

        [BsonElement(elementName: "CEP_BAIRRO")]
        public string Bairro { get; set; }

        [BsonElement(elementName: "CEP_IBGE")]
        public int? Ibge { get; set; }

        [BsonElement(elementName: "CIDADE")]
        public virtual CidadeNotification Cidade { get; set; }
    }
}
