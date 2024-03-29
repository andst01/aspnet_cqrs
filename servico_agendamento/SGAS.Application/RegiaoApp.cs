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
    public class RegiaoApp : IRegiaoApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IRegiaoQueryRepository _query;

        public RegiaoApp(IMapper mapper, 
                         IMediatorHandler mediatorHandler, 
                         IRegiaoQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<RegiaoNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<RegiaoNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Regiao> Register(RegiaoViewModel request)
        {
            var command = _mapper.Map<RegiaoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Regiao>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new RegiaoDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Regiao> Update(RegiaoViewModel request)
        {
            var command = _mapper.Map<RegiaoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Regiao>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
