using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Entity
{
    public class Log
    {
        public Int64 LogID { get; set; }

        public string UserID { get; set; }

        public DateTime EventDateUTC { get; set; }

        public string EventType { get; set; }

        public string TableName { get; set; }

        public string ClassName { get; set; }

        public string RecordID { get; set; }

        public string ColumnName { get; set; }

        public string OriginalValue { get; set; }

        public string NewValue{ get; set; }
    }
}
