using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class MicroRegiaoNotificationHandler
        : INotificationHandler<MicroRegiaoCreateNotification>,
          INotificationHandler<MicroRegiaoUpdateNotification>,
          INotificationHandler<MicroRegiaoDeleteNotification>
    {
        public Task Handle(MicroRegiaoCreateNotification notification, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
        }

        public Task Handle(MicroRegiaoUpdateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(MicroRegiaoDeleteNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
