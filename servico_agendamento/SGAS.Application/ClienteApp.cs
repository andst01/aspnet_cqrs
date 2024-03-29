using AutoMapper;
using SGAS.Application.Interfaces;
using SGAS.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using SGAS.Domain.Interfaces.RepositoryQuery;
using FluentValidation.Results;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Mediator;
using SGAS.Domain.Notifications;

namespace SGAS.Application
{
    public class ClienteApp :  IClienteApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IClienteQueryRepository _query;

        public ClienteApp(IMapper mapper, 
                          IMediatorHandler mediatorHandler, 
                          IClienteQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<ClienteNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<ClienteNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Cliente> Register(ClienteViewModel request)
        {
            var command = _mapper.Map<ClienteCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Cliente>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new ClienteDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Cliente> Update(ClienteViewModel request)
        {
            var command = _mapper.Map<ClienteUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Cliente>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
