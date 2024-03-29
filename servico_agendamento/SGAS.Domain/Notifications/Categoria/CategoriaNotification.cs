using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("CATEGORIA")]
    public class CategoriaNotification : EventBase
    {
        [BsonElement(elementName: "CATE_ID")]
        public override int Id { get; set; }
        [BsonElement(elementName: "CATE_DESCRICAO")]
        public string Descricao { get; set; }

        [BsonElement(elementName:"PRODUTOS")]
        public virtual ICollection<ProdutoNotification> Produto { get; set; }
    }
}
