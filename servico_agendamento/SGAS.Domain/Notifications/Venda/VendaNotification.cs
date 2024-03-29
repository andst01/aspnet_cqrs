using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("VENDA")]
    public class VendaNotification : EventBase
    {
        [BsonElement("VEND_ID")]
        public override int Id { get; set; }

        [BsonElement("VEND_VALOR")]
        public decimal Valor { get; set; }

        [BsonElement("VEND_DESCONTO")]
        public decimal Desconto { get; set; }

        [BsonElement("VEND_ID_CLIENTE")]
        public int IdCliente { get; set; }

        [BsonElement("CLIENTE")]
        public virtual ClienteNotification Cliente { get; set; }

        [BsonElement("VEND_ID_FUNCIONARIO")]
        public int? IdFuncionario { get; set; }

        [BsonElement("FUNCIONARIO")]
        public virtual FuncionarioNotification Funcionario { get; set; }

        [BsonElement("VEND_ID_UNIDADE_VENDA")]
        public int? IdUnidadeVenda { get; set; }

        [BsonElement("UNIDADE_VENDA")]
        public virtual UnidadeVendaNotification UnidadeVenda { get; set; }

        [BsonElement("ITEM_VENDA")]
        public virtual ICollection<ItemVendaNotification> ItemVenda { get; set; }

    }


}
