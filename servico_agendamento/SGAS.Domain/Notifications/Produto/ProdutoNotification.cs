using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("PRODUTO")]
    public class ProdutoNotification : EventBase
    {
        [BsonElement("PROD_ID")]
        public override int Id { get; set; }

        [BsonElement("PROD_DESCRICAO")]
        public string Descricao { get; set; }

        [BsonElement("PROD_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [BsonElement("PROD_DATA_ATUALIZACAO")]
        public DateTime DataAtualizacao { get; set; }

        [BsonElement("PROD_PRECO")]
        public decimal Preco { get; set; }

        [BsonElement("PROD_ATIVO")]
        public bool? Ativo { get; set; }

        [BsonElement("PROD_ID_CATEGORIA")]
        public int IdCategoria { get; set; }

        [BsonElement("CATEGORIA")]
        public virtual CategoriaNotification Categoria { get; set; }

        [BsonElement("ITENSVENDAS")]
        public virtual ICollection<ItemVendaNotification> ItemVendas { get; set; }


    }
}
