using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("FUNCIONARIO")]
    public class FuncionarioNotification : EventBase
    {
        [BsonElement("FNCR_ID")]
        public override int Id { get; set; }

        [BsonElement("RESPONSAVEIS_SERVICOS")]
        public List<AgendamentoNotification> ResponsaveisServico { get; set; }

        [BsonElement("ATENDENTES")]
        public List<AgendamentoNotification> Atendentes { get; set; }

        [BsonElement("CARGOS_FUNCIONARIOS")]
        public List<CargoFuncionarioNotification> CargosFuncionario { get; set; }

        [BsonElement("AGENDAS")]
        public List<AgendaNotification> Agendas { get; set; }

        [BsonElement("FNCR_ID_PESSOA")]
        public int IdPessoa { get; set; }

        [BsonElement("PESSOA")]
        public virtual PessoaNotification Pessoa { get; set; }

        [BsonElement("FNCR_CPF")]
        public string CPF { get; set; }

        [BsonElement("FNCR_RG")]
        public string RG { get; set; }

        [BsonElement("FNCR_NOME")]
        public string Nome { get; set; }

        [BsonElement("FNCR_DATA_NASCIMENTO")]
        public DateTime DataNascimento { get; set; }

        [BsonElement("VENDAS")]
        public List<Venda> Vendas { get; set; }
    }
}
