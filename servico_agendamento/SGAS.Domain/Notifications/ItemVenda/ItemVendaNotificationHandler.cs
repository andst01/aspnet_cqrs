using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class ItemVendaNotificationHandler
                    : INotificationHandler<ItemVendaCreateNotification>,
                      INotificationHandler<ItemVendaUpdateNotification>,
                      INotificationHandler<ItemVendaDeleteNotification>

    {
        public async Task Handle(ItemVendaCreateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Handle(ItemVendaUpdateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Handle(ItemVendaDeleteNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
