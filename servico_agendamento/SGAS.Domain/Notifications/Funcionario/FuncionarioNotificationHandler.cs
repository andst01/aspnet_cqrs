using MediatR;
using MongoDB.Driver;
using SGAS.Domain.Interfaces.RepositoryQuery;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class FuncionarioNotificationHandler :
        INotificationHandler<FuncionarioCreateNotification>,
        INotificationHandler<FuncionarioUpdateNotification>,
        INotificationHandler<FuncionarioDeleteNotification>
    {

        private readonly IFuncionarioQueryRepository _repository;

        public FuncionarioNotificationHandler(IFuncionarioQueryRepository repository)
        {
            _repository = repository;
        }

        public Task Handle(FuncionarioCreateNotification notification, CancellationToken cancellationToken)
        {
            // _repository.Add(notification);
            return Task.CompletedTask;
        }

        public Task Handle(FuncionarioUpdateNotification notification, CancellationToken cancellationToken)
        {
            _repository.Update(Builders<FuncionarioNotification>.Filter.Where(x => x.Id == notification.Id), notification);
            return Task.CompletedTask;
        }

        public Task Handle(FuncionarioDeleteNotification notification, CancellationToken cancellationToken)
        {
            _repository.Remove(Builders<FuncionarioNotification>.Filter.Where(x => x.Id == notification.Id));
            return Task.CompletedTask;
        }
    }
}
