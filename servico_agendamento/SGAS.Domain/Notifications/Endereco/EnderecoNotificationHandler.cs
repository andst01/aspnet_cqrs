using MediatR;
using MongoDB.Driver;
using SGAS.Domain.Interfaces.RepositoryQuery;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class EnderecoNotificationHandler :
        INotificationHandler<EnderecoCreateNotification>,
        INotificationHandler<EnderecoUpdateNotification>,
        INotificationHandler<EnderecoDeleteNotification>
    {

        private readonly IEnderecoQueryRepository _repository;

        public EnderecoNotificationHandler(IEnderecoQueryRepository repository)
        {
            _repository = repository;
        }

        public Task Handle(EnderecoCreateNotification notification, CancellationToken cancellationToken)
        {
            _repository.Add(notification);
            return Task.CompletedTask;
        }

        public Task Handle(EnderecoUpdateNotification notification, CancellationToken cancellationToken)
        {
            _repository.Update(Builders<EnderecoNotification>.Filter.Where(x => x.Id == notification.Id), notification);
            return Task.CompletedTask;
        }

        public Task Handle(EnderecoDeleteNotification notification, CancellationToken cancellationToken)
        {
            _repository.Remove(Builders<EnderecoNotification>.Filter.Where(x => x.Id == notification.Id));
            return Task.CompletedTask;
        }
    }
}
