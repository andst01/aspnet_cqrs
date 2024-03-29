using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Utils
{
    public class NotificationErro : INotification
    {
        public string Mensagem { get; set; }
        public string Pilha { get; set; }
    }
}
