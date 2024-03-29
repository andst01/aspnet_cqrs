
using MediatR;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class AgendaNotificationHandler :
        INotificationHandler<AgendaCreateNotification>,
        INotificationHandler<AgendaUpdateNotification>,
        INotificationHandler<AgendaDeleteNotification>
    {
        public Task Handle(AgendaDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>  $"Dados Excluídos com sucesso {JsonConvert.SerializeObject(notification)}" );
        }

        public Task Handle(AgendaUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => $"Dados Alterados com sucesso {JsonConvert.SerializeObject(notification)}");
        }

        public Task Handle(AgendaCreateNotification notification, CancellationToken cancellationToken)
        {
            AgendaNotification agendaNotification = notification;
            return Task.Run(() => $"Dados Incluídos com sucesso {JsonConvert.SerializeObject(notification)}");
        }
    }
}
