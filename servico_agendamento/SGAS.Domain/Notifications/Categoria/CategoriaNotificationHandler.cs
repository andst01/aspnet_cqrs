using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class CategoriaNotificationHandler :
        INotificationHandler<CategoriaCreateNotification>,
        INotificationHandler<CategoriaUpdateNotification>,
        INotificationHandler<CategoriaDeleteNotification>
    {
        public async Task Handle(CategoriaCreateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Handle(CategoriaUpdateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Handle(CategoriaDeleteNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
