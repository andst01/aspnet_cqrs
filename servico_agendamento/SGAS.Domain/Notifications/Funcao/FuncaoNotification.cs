using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System.Collections.Generic;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("FUNCAO")]
    public class FuncaoNotification : EventBase
    {
        [BsonElement("FUNC_ID")]
        public override int Id { get; set; }

        [BsonElement("FUNC_NOME")]
        public virtual string Name { get; set; }

        [BsonElement("FUNC_NORMALIZED_NAME")]
        public virtual string NormalizedName { get; set; }

        [BsonElement("FUNC_CONCURRENCY_TEMP")]
        public virtual string ConcurrencyStamp { get; set; }

        [BsonElement("FUNCOES_USUARIOS")]
        public ICollection<FuncaoUsuarioNotification> FuncoesUsuarios { get; set; }
    }
}
