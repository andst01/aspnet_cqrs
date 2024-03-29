using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class FuncaoNotificationHandler : 
        INotificationHandler<FuncaoCreateNotification>,
        INotificationHandler<FuncaoUpdateNotification>,
        INotificationHandler<FuncaoDeleteNotification>
    {
        public Task Handle(FuncaoUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(FuncaoCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(FuncaoDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
