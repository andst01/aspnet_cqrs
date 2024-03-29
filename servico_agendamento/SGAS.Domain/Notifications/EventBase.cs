using MediatR;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SGAS.Domain.Notifications
{
    public abstract class EventBase : INotification
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        // [BsonElement("id")]
       
        public ObjectId _Id { get; set; }
        public virtual int Id { get;  set; }
       

    }
}
