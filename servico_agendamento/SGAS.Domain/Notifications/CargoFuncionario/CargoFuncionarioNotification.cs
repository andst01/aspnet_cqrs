using MongoDB.Bson.Serialization.Attributes;
using SGAS.Domain.Utils;
using System;

namespace SGAS.Domain.Notifications
{
    [BsonCollection("CARGO_FUNCIONARIO")]
    public class CargoFuncionarioNotification : EventBase
    {
        [BsonElement(elementName:"CGFN_ID")]
        public override int Id { get; set; }

        [BsonElement(elementName: "CGFN_ID_FUNCIONARIO")]
        public int IdFuncionario { get; set; }

        [BsonElement(elementName: "FUNCIONARIO")]
        public FuncionarioNotification Funcionario { get; set; }

        [BsonElement(elementName: "CGFN_ID_CARGO")]
        public int IdCargo { get; set; }

        [BsonElement(elementName: "CARGO")]
        public CargoNotification Cargo { get; set; }

        [BsonElement(elementName: "CGFN_DATA_INICIO")]
        public DateTime DataInicio { get; set; }

        [BsonElement(elementName: "CGFN_DATA_FIM")]
        public DateTime? DataFim { get; set; }
    }
}
