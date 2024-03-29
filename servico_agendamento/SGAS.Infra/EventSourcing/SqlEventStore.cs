using SGAS.Domain.Notifications;
using SGAS.Infra.Identity;
using SGAS.Domain.Interfaces.Repository;

namespace SGAS.Infra.EventSourcing
{
    public class SqlEventStore : IEventStore
    {
        private readonly IHistoricoEventoRepository _repository;
        private readonly IUser _user;

        public SqlEventStore(IHistoricoEventoRepository repository, IUser user)
        {
            _repository = repository;
            _user = user;
        }

        //public async Task<bool?> Save<T>(T evento) where T : EventBase
        //{
           
        //   // var storedEvent = new HistoricoEvento(evento, _user.ObterUsuario());

        //    return await _repository.Store(storedEvent);
        //}
    }
}
