using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class UsuarioNotificationHandler : 
        INotificationHandler<UsuarioCreateNotification>,
        INotificationHandler<UsuarioUpdateNotification>,
        INotificationHandler<UsuarioDeleteNotification>
    {
        public Task Handle(UsuarioCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(UsuarioUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(UsuarioDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
