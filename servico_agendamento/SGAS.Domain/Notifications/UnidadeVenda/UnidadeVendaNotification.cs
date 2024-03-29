using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("UNIDADE_VENDA")]
    public class UnidadeVendaNotification : EventBase
    {
        [BsonElement("UNVD_ID")]
        public override int Id { get; set; }

        [BsonElement("AGENDAMENTOS")]
        public List<AgendamentoNotification> Agendamentos { get; set; }

        [BsonElement("AGENDAS")]
        public List<AgendaNotification> Agendas { get; set; }

        [BsonElement("VENDAS")]
        public List<VendaNotification> Vendas { get; set; }

        [BsonElement("UNVD_ID_EMPRESA")]
        public int IdEmpresa { get; set; }

        [BsonElement("EMPRESA")]
        public virtual EmpresaNotification Empresa { get; set; }

        [BsonElement("PESSOA")]
        public virtual Pessoa Pessoa { get; set; }

        [BsonElement("UNVD_ID_PESSOA")]
        public int IdPessoa { get; set; }

        [BsonElement("UNVD_CNPJ")]
        public string CNPJ { get; set; }

        [BsonElement("UNVD_NOME_FANTASIA")]
        public string NomeFantasia { get; set; }

        [BsonElement("UNVD_RAZAO_SOCIAL")]
        public string RazaoSocial { get; set; }



    }
}
