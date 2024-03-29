using AutoMapper;
using FluentValidation.Results;
using SGAS.Application.Interfaces;
using SGAS.Application.ViewModels;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Mediator;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGAS.Application
{
    public class CepApp : ICepApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly ICepQueryRepository _query;

        public CepApp(IMapper mapper,
                       IMediatorHandler mediatorHandler, 
                       ICepQueryRepository query)
        {
            _mediatorHandler = mediatorHandler;
            _mapper = mapper;
            _query = query;
        }

        public async Task<IEnumerable<CepNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<CepNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Cep> Register(CepViewModel request)
        {
            var command = _mapper.Map<CepCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Cep>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new CepCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Cep> Update(CepViewModel request)
        {
            var command = _mapper.Map<CepUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Cep>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
