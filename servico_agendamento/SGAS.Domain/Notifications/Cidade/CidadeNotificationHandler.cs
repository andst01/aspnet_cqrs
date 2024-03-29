using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class CidadeNotificationHandler :
        INotificationHandler<CidadeCreateNotification>,
        INotificationHandler<CidadeUpdateNotification>,
        INotificationHandler<CidadeDeleteNotification>
    {
        public Task Handle(CidadeCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CidadeUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CidadeDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
