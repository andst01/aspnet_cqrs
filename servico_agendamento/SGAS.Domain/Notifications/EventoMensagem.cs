using MediatR;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Notifications
{
    [BsonIgnoreExtraElements]
    public abstract class EventoMensagem 
    {
        [BsonIgnore]
        public int CodigoMensagem { get; protected set; }

        [BsonIgnore]
        public virtual string TipoMensagem { get; protected set; }

        protected EventoMensagem()
        {
            TipoMensagem = GetType().Name;
        }
    }

    
}
