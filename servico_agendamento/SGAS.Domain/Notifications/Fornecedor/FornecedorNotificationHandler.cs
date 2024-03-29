using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class FornecedorNotificationHandler : INotificationHandler<FornecedorCreateNotification>,
                                       INotificationHandler<FornecedorUpdateNotification>,
                                       INotificationHandler<FornecedorDeleteNotification>
    {
        public Task Handle(FornecedorCreateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(FornecedorDeleteNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(FornecedorUpdateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
