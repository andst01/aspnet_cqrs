using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class MesoRegiaoNotificationHandler
        : INotificationHandler<MesoRegiaoCreateNotification>,
          INotificationHandler<MesoRegiaoUpdateNotification>,
          INotificationHandler<MesoRegiaoDeleteNotification>
    {
        public Task Handle(MesoRegiaoCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(MesoRegiaoUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(MesoRegiaoDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
