using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class UnidadeVendaNotificationHandler :
        INotificationHandler<UnidadeVendaCreateNotification>,
        INotificationHandler<UnidadeVendaUpdateNotification>,
        INotificationHandler<UnidadeVendaDeleteNotification>
    {
        public Task Handle(UnidadeVendaCreateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(UnidadeVendaUpdateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(UnidadeVendaDeleteNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
