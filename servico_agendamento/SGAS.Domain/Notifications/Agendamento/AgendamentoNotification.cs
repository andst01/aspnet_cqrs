using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("AGENDAMENTO")]
    public class AgendamentoNotification : EventBase
    {

        [BsonElement(elementName: "AGMT_ID")]
        public override int Id { get; set; }

        [BsonElement(elementName: "AGMT_DATA_INICIO")]
        public DateTime DataInicio { get; set; }

        [BsonElement(elementName: "AGMT_DATA_FINAL")]
        public DateTime DataFinal { get; set; }

        [BsonElement(elementName: "AGMT_DIA_INTEIRO")]
        public bool DiaInteiro { get; set; }

        [BsonElement(elementName: "AGMT_VISITA_EM_CASA")]
        public bool VisitaEmCasa { get; set; }

        [BsonElement(elementName: "AGMT_STATUS")]
        public int Status { get; set; }

        [BsonElement(elementName: "RESPONSAVEL_SERVICO")]
        public virtual FuncionarioNotification ResponsavelServico { get; set; }

        [BsonElement(elementName: "AGMT_ID_RESP_SERVICO")]
        public int? IdResponsavelServico { get; set; }

        [BsonElement(elementName: "AGMT_ID_ATENDENTE")]
        public int? IdAtendente { get; set; }

        [BsonElement(elementName: "ATENDENTE")]
        public virtual FuncionarioNotification Atendente { get; set; }

        [BsonElement(elementName: "CLIENTE")]
        public virtual ClienteNotification Cliente { get; set; }

        [BsonElement(elementName: "AGMT_ID_CLIENTE")]
        public int IdCliente { get; set; }

        [BsonElement(elementName: "SERVICOS")]
        public virtual List<ServicoNotification> Servico { get; set; }

        [BsonElement(elementName: "AGMT_ID_UNIDADEVENDA")]
        public int? IdUnidadeVenda { get; set; }

        [BsonElement(elementName: "UNIDADEVENDA")]
        public virtual UnidadeVendaNotification UnidadeVenda { get; set; }
    }
}
