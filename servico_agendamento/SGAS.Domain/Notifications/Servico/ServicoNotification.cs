using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("SERVICO")]
    public class ServicoNotification : EventBase
    {
        [BsonElement("SERV_ID")]
        public override int Id { get; set; }

        [BsonElement("SERV_ID_AGENDAMENTO")]
        public int IdAgendamento { get; set; }

        [BsonElement("AGENDAMENTO")]
        public virtual AgendamentoNotification Agendamento { get; set; }

        [BsonElement("SERV_ID_RESPONSAVEL")]
        public int IdUsuarioResponsavel { get; set; }

        [BsonElement("SERV_COD_SERVICO")]
        public int CodigoServico { get; set; }

        [BsonElement("SERV_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [BsonElement("SERV_ID_USUARIO")]
        public int IdUsuarioCriacao { get; set; }

        [BsonElement("SERV_QTD_PARCELAS")]
        public int QuantidadeParcelas { get; set; }

        [BsonElement("SERV_VL_TOTAL")]
        public decimal ValorTotal { get; set; }

        [BsonElement("USUARIO_CRIACAO")]
        public UsuarioNotification UsuarioCriacao { get; set; }

        [BsonElement("USUARIO_RESPONSAVEL")]
        public UsuarioNotification UsuarioResponsavel { get; set; }

    }
}
