using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class CepNotificationHandler :
        INotificationHandler<CepCreateNotification>,
        INotificationHandler<CepUpdateNotification>,
        INotificationHandler<CepDeleteNotification>
    {

        public Task Handle(CepCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CepUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CepDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        
    }
}
