using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class MotivoNotificationHandler :

        INotificationHandler<MotivoCreateNotification>,
        INotificationHandler<MotivoUpdateNotification>,
        INotificationHandler<MotivoDeleteNotification>
    {
        public Task Handle(MotivoDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(MotivoUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(MotivoCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
