using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;
using System;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("AGENDA")]
    public class AgendaNotification : EventBase
    {
        [BsonElement("AGDA_ID")]
        public override int Id { get; set; }
        [BsonElement(elementName:"AGDA_DATA_INICIO")]
        public DateTime DataInicio { get; set; }
        [BsonElement(elementName: "AGDA_DATA_FIM")]
        public DateTime DataFim { get; set; }
        [BsonElement(elementName: "AGDA_ID_UNIDADEVENDA")]
        public int IdUnidadeVenda { get; set; }
        [BsonElement(elementName: "AGDA_PRESENCA")]
        public int Presenca { get; set; }
        [BsonElement(elementName: "AGDA_ID_MOTIVO")]
        public int IdMotivo { get; set; }
        [BsonElement(elementName: "MOTIVO")]
        public virtual MotivoNotification Motivo { get; set; }
        [BsonElement(elementName: "AGDA_OBSERVACAO")]
        public string Observacao { get; set; }
        [BsonElement(elementName: "UNIDADE_VENDA")]
        public UnidadeVendaNotification UnidadeVenda { get; set; }

        [BsonElement(elementName: "FUNCIONARIO")]
        public FuncionarioNotification Funcionario { get; set; }

        [BsonElement(elementName: "AGDA_ID_FUNCIONARIO")]
        public int IdFuncionario { get; set; }


    }
}
