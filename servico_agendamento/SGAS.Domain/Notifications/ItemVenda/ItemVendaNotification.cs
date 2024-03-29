using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("ITEM_VENDA")]
    public class ItemVendaNotification : EventBase
    {
        [BsonElement("ITVD_ID")]
        public override int Id { get; set; }

        [BsonElement("ITVD_ID_PRODUTO")]
        public int IdProduto { get; set; }

        [BsonElement("ITVD_QUANTIDADE")]
        public int Quantidade { get; set; }

        [BsonElement("ITVD_VALOR_UNITARIO")]
        public decimal ValorUnitario { get; set; }

        [BsonElement("ITVD_VALOR_TOTAL")]
        public decimal ValorTotal { get; set; }

        [BsonElement("ITVD_DESCONTO")]
        public decimal Desconto { get; set; }

        [BsonElement("ITVD_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [BsonElement("ITVD_DATA_ATUALIZACAO")]
        public DateTime DataAtualizacao { get; set; }

        [BsonElement("ITVD_ID_VENDA")]
        public int IdVenda { get; set; }

        [BsonElement("PRODUTO")]
        public virtual ProdutoNotification Produto { get; set; }

        [BsonElement("VENDA")]
        public virtual VendaNotification Venda { get; set; }
    }
}
