using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class AgendamentoNotificationHandler :
        INotificationHandler<AgendamentoCreateNotification>,
        INotificationHandler<AgendamentoUpdateNotification>,
        INotificationHandler<AgendamentoDeleteNotification>
    {
        public Task Handle(AgendamentoCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(AgendamentoUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(AgendamentoDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
