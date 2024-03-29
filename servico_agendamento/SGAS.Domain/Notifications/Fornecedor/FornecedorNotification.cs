using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("FORNECEDOR")]
    public class FornecedorNotification : EventBase
    {
        [BsonElement("FORN_ID")]
        public override int Id { get; set; }

        [BsonElement("FORN_ID_PESSOA")]
        public int IdPessoa { get; set; }

        [BsonElement("FORN_CNPJ")]
        public string CNPJ { get; set; }

        [BsonElement("FORN_NOME_FANTASIA")]
        public string NomeFantasia { get; set; }

        [BsonElement("FORN_RAZAO_SOCIAL")]
        public string RazaoSocial { get; set; }

        [BsonElement("PESSOA")]
        public PessoaCreateNotification Pessoa { get; set; }


    }
}
