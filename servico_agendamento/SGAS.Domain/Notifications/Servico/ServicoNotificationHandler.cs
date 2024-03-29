using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class ServicoNotificationHandler :
         INotificationHandler<ServicoCreateNotification>,
        INotificationHandler<ServicoUpdateNotification>,
        INotificationHandler<ServicoDeleteNotification>

    {
        public Task Handle(ServicoCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ServicoUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ServicoDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
