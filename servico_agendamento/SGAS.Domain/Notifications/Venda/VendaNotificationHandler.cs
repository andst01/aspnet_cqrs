using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class VendaNotificationHandler :
        INotificationHandler<VendaCreateNotification>,
        INotificationHandler<VendaUpdateNotification>,
        INotificationHandler<VendaDeleteNotification>
    {
       
        public Task Handle(VendaCreateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(VendaUpdateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(VendaDeleteNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
