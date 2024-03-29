using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class ClienteNotificationHandler :
        INotificationHandler<ClienteCreateNotification>,
        INotificationHandler<ClienteUpdateNotification>,
        INotificationHandler<ClienteDeleteNotification>
    {
        public Task Handle(ClienteCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ClienteUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ClienteDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
