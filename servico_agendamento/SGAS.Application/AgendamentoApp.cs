using AutoMapper;
using FluentValidation.Results;
using SGAS.Application.Interfaces;
using SGAS.Application.ViewModels;
using SGAS.Domain.Notifications;
using System.Collections.Generic;
using System.Threading.Tasks;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Infra.Context;
using SGAS.Domain.Interfaces.Mediator;

namespace SGAS.Application
{
    public class AgendamentoApp :  IAgendamentoApp
    {
        private readonly IMapper _mapper;
        private readonly IAgendamentoQueryRepository _query;
        private readonly IMediatorHandler _mediatorHandler;
       

        public AgendamentoApp(IMapper mapper,
                              IMediatorHandler mediatorHandler,
                              IAgendamentoQueryRepository query)
                             
        {
            _query = query;
            _mediatorHandler = mediatorHandler;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AgendamentoNotification>> GetAll()
        {
           return await _query.GetAll();
        }

        public async Task<AgendamentoNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Agendamento> Register(AgendamentoViewModel request)
        {
            var command = _mapper.Map<AgendamentoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Agendamento>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new AgendaDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Agendamento> Update(AgendamentoViewModel request)
        {
            var command = _mapper.Map<AgendamentoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Agendamento>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
