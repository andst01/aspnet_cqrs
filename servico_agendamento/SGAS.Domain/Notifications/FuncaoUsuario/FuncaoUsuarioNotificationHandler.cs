using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class FuncaoUsuarioNotificationHandler 
        : INotificationHandler<FuncaoUsuarioCreateNotification>,
        INotificationHandler<FuncaoUsuarioUpdateNotification>,
        INotificationHandler<FuncaoUsuarioDeleteNotification>
    {
        public Task Handle(FuncaoUsuarioCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(FuncaoUsuarioUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(FuncaoUsuarioDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
