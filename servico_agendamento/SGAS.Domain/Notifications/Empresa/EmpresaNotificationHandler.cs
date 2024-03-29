using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class EmpresaNotificationHandler 
                                     : INotificationHandler<EmpresaCreateNotification>,
                                       INotificationHandler<EmpresaUpdateNotification>,
                                       INotificationHandler<EmpresaDeleteNotification>

    {
        public Task Handle(EmpresaCreateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(EmpresaUpdateNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Handle(EmpresaDeleteNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
