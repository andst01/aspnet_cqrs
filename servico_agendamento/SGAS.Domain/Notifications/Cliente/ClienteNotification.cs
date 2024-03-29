using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("CLIENTE")]
    public class ClienteNotification : EventBase
    {
        [BsonElement(elementName: "CLIE_ID")]
        public override int Id { get; set; }

        [BsonElement(elementName: "AGENDAMENTOS")]
        public List<Agendamento> Agendamentos { get; set; }

        [BsonElement(elementName: "VENDAS")]
        public List<Venda> Vendas { get; set; }

        [BsonElement(elementName: "PESSOA")]
        public virtual Pessoa Pessoa { get; set; }

        [BsonElement(elementName: "CLIE_ID_PESSOA")]
        public int IdPessoa { get; set; }

        [BsonElement(elementName: "CLIE_CPF")]
        public string CPF { get; set; }

        [BsonElement(elementName: "CLIE_RG")]
        public string RG { get; set; }

        [BsonElement(elementName: "CLIE_NOME")]
        public string Nome { get; set; }

        [BsonElement(elementName: "CLIE_DATA_NASCIMENTO")]
        public DateTime DataNascimento { get; set; }
    }
}
