using AutoMapper;
using FluentValidation.Results;
using SGAS.Application.Interfaces;
using SGAS.Application.ViewModels;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;
using System.Collections.Generic;
using System.Threading.Tasks;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Infra.Context;
using SGAS.Domain.Interfaces.Mediator;

namespace SGAS.Application
{
    public class AgendaApp :  IAgendaApp
    {

        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IAgendaQueryRepository _query;
       

        public AgendaApp(IMapper mapper, 
                         IMediatorHandler mediatorHandler,
                         IAgendaQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<AgendaNotification>> GetAll()
        {
            return await _query.GetAll();           
        }

        public async Task<AgendaNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Agenda> Register(AgendaViewModel request)
        {
            var command = _mapper.Map<AgendaCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Agenda>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new AgendaDeleteCommand() { Id = id });
            if(response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;

        }

        public async Task<Agenda> Update(AgendaViewModel request)
        {
            var command = _mapper.Map<AgendaUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Agenda>(command);
            if(response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;

        }
    }
}
