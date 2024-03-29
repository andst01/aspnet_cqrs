using MediatR;
using MongoDB.Driver;
using SGAS.Domain.Interfaces.RepositoryQuery;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public class PessoaNotificationHandler :
        INotificationHandler<PessoaCreateNotification>,
        INotificationHandler<PessoaUpdateNotification>,
        INotificationHandler<PessoaDeleteNotification>
    {
        private readonly IPessoaQueryRepository _repository;

        public PessoaNotificationHandler(IPessoaQueryRepository repository)
        {
            _repository = repository;
        }

        public Task Handle(PessoaCreateNotification notification, CancellationToken cancellationToken)
        {
            _repository.Add(notification);
            return Task.CompletedTask;
        }

        public Task Handle(PessoaUpdateNotification notification, CancellationToken cancellationToken)
        {
            _repository.Update(Builders<PessoaNotification>.Filter.Where(x => x.Id == notification.Id), notification);
            return Task.CompletedTask;
        }

        public Task Handle(PessoaDeleteNotification notification, CancellationToken cancellationToken)
        {
            _repository.Remove(Builders<PessoaNotification>.Filter.Where(x => x.Id == notification.Id));
            return Task.CompletedTask;
        }
    }
}
