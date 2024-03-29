using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;
using SGAS.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("FUNCAO_USUARIO")]
    public class FuncaoUsuarioNotification : EventBase
    {
        [BsonElement("FNUS_ID_USUARIO")]
        public int UserId { get; set; }

        [BsonElement("FNUS_ID_FUNCAO")]
        public int  RoleId { get; set; }

        [BsonElement("FUNCAO")]
        public FuncaoNotification Role { get; set; }

        [BsonElement("USUARIO")]
        public UsuarioNotification User { get; set; }

        [BsonElement("FUNC_DT_INICIO")]
        public DateTime DataInicio { get; set; }

        [BsonElement("FUNC_DT_FIM")]
        public DateTime? DataFim { get; set; }
    }
}
