using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class ProdutoNotificationHandler :
        INotificationHandler<ProdutoCreateNotification>,
        INotificationHandler<ProdutoUpdateNotification>,
        INotificationHandler<ProdutoDeleteNotification>
    {
        public Task Handle(ProdutoCreateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(ProdutoUpdateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(ProdutoDeleteNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
