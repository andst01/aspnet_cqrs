using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Utils;
using System;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("PESSOA")]
    public class PessoaNotification : EventBase
    {
        [BsonElement("PESS_ID")]
        public override int Id { get; set; }

        [BsonElement("PESS_ESTRANGEIRO")]
        public bool EhEstrangeiro { get; set; }

        [BsonElement("PESS_OBSERVACAO")]
        public string Observacao { get; set; }

        [BsonElement("PESS_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [BsonElement("PESS_DATA_ALTERACAO")]
        public DateTime DataAlteracao { get; set; }

        [BsonElement("PESS_TELEFONE")]
        public string Telefone { get; set; }

        [BsonElement("PESS_CELULAR")]
        public string Celular { get; set; }

        [BsonElement("PESS_EMAIL")]
        public string Email { get; set; }

        [BsonElement("ENDERECO")]
        public virtual EnderecoNotification Endereco { get; set; }

        [BsonElement("PESS_ID_USUARIO")]
        public int IdUsuario { get; set; }

        [BsonElement("USUARIO")]
        public virtual UsuarioNotification Usuario { get; set; }

        [BsonElement("FUNCIONARIO")]
        public virtual FuncionarioNotification Funcionario { get; set; }

        [BsonElement("CLIENTE")]
        public virtual ClienteNotification Cliente { get; set; }

        [BsonElement("EMPRESA")]
        public virtual EmpresaNotification Empresa { get; set; }

        [BsonElement("FORNECEDOR")]
        public virtual FornecedorNotification Fornecedor { get; set; }

        [BsonElement("UNIDADEVENDA")]
        public virtual UnidadeVendaNotification UnidadeVenda { get; set; }


    }
}
