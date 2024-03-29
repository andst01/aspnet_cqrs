using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class ItemServicoEventHandler :
        INotificationHandler<ItemServicoCreateEvent>,
        INotificationHandler<ItemServicoUpdateEvent>,
        INotificationHandler<ItemServicoDeleteEvent>
    {
        public  Task Handle(ItemServicoDeleteEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ItemServicoUpdateEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ItemServicoCreateEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
