using MediatR;
using System.Threading.Tasks;
using SGAS.Domain.Command;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SGAS.Domain.Entity;
using System.Collections.Generic;
using System.Linq;
using SGAS.Domain.Interfaces.Mediator;

namespace SGAS.Domain.Notifications
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _ctx;
        

        public InMemoryBus(IMediator mediator, 
                           IHttpContextAccessor ctx)
        {
            _mediator = mediator;
            _ctx = ctx;
        }

        public async Task<bool?> PublishEvent<T>(T @event) where T : EventBase
        {
            bool? publishEvent = null;

            //return await _repository.Store(storedEvent);

            //if (!@event.TipoMensagem.Equals("DomainNotification"))
            //{

            //    var storedEvent = new HistoricoEvento(@event, _ctx.HttpContext.User.Identity.Name);

            //    publishEvent = await _repository.Store(storedEvent);
            //}

            await _mediator.Publish(@event);

            return publishEvent;
        }


        public async Task PublishEvent_2<T>(T context) where T : DbContext
        {
            //bool? publishEvent = null;

            bool? publishEvent = null;
            context.ChangeTracker.DetectChanges();

            List<EntityEntry<EntidadeBase>> domainEntities = context.ChangeTracker
                .Entries<EntidadeBase>()
                .Where(x =>
                            x.Entity.DomainEvents != null &&
                            x.Entity.DomainEvents.Any()).ToList();




            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();
            //   response.AddDomainEvent(_mapper.Map<AgendamentoCreateNotification>(objeto));
            var domainEvents1 = domainEntities
                .Select(x => x.Entity)
                .ToList();



            domainEntities.ToList()
                .ForEach(entity => entity.Entity.ClearDomainEvents());


            var tasks = domainEvents
                .Select(async (domainEvent) =>
                {
                    await _mediator.Publish(domainEvent);
                });


        }

        public async Task<ValidationResult> SendCommand<T>(T command) where T : BaseCommand
        {
            return await _mediator.Send(command);
        }


        public async Task<T> SendCommand<T>(IRequest<T> command) where T : class
        {
            return await _mediator.Send<T>(command);
        }

    }
}
