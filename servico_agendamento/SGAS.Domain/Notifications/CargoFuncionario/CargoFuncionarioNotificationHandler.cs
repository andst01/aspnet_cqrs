using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class CargoFuncionarioNotificationHandler :
        INotificationHandler<CargoFuncionarioCreateNotification>,
        INotificationHandler<CargoFuncionarioUpdateNotification>,
        INotificationHandler<CargoFuncionarioDeleteNotification>
    {
        public Task Handle(CargoFuncionarioCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CargoFuncionarioUpdateNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CargoFuncionarioDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
