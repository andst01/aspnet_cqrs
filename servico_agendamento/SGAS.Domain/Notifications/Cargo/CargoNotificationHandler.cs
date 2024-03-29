using MediatR;
using MongoDB.Driver;
using SGAS.Domain.Interfaces.RepositoryQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class CargoNotificationHandler : 
        INotificationHandler<CargoCreateNotification>,
        INotificationHandler<CargoUpdateNotification>,
        INotificationHandler<CargoDeleteNotification>
    {
        private readonly ICargoQueryRepository _repository;
        public CargoNotificationHandler(ICargoQueryRepository repository)
        {
            _repository = repository;
        }
        public Task Handle(CargoCreateNotification notification, CancellationToken cancellationToken)
        {
            
            _repository.Add(notification);
            return  Task.CompletedTask;
        }

        public Task Handle(CargoUpdateNotification notification, CancellationToken cancellationToken)
        {
            //var filter = Builders<CargoNotification>.Filter.Where(x => x.Id == notification.Id);
            _repository.Update(Builders<CargoNotification>.Filter.Where(x => x.Id == notification.Id), notification);
            return Task.CompletedTask;
        }

        public Task Handle(CargoDeleteNotification notification, CancellationToken cancellationToken)
        {
            _repository.Remove(Builders<CargoNotification>.Filter.Where(x => x.Id == notification.Id));
            return Task.CompletedTask;
        }
    }
}
