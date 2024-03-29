using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class RegiaoNotificationHandler
        : INotificationHandler<RegiaoCreateNotification>,
          INotificationHandler<RegiaoUpdateNotification>,
          INotificationHandler<RegiaoDeleteNotification>
    {
        public Task Handle(RegiaoCreateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(RegiaoUpdateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(RegiaoDeleteNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
