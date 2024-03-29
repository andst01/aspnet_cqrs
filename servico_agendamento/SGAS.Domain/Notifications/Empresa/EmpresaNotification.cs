using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("EMPRESA")]
    public class EmpresaNotification : EventBase
    {
        [BsonElement(elementName: "EMPR_ID")]
        public override int Id { get; set; }

        [BsonElement(elementName: "EMPR_ID_PESSOA")]
        public int IdPessoa { get; set; }

        [BsonElement(elementName: "EMPR_CNPJ")]
        public string CNPJ { get; set; }

        [BsonElement(elementName: "EMPR_NOME_FANTASIA")]
        public string NomeFantasia { get; set; }

        [BsonElement(elementName: "UNIDADEVENDAS")]
        public List<UnidadeVendaCreateNotification> UnidadeVendas { get; set; }

        [BsonElement(elementName: "PESSOA")]
        public PessoaCreateNotification Pessoa { get; set; }

        [BsonElement(elementName: "EMPR_RAZAO_SOCIAL")]
        public string RazaoSocial { get; set; }

       
    }
}
