using AutoMapper;
using FluentValidation.Results;
using SGAS.Application.Interfaces;
using SGAS.Application.ViewModels;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Interfaces.Mediator;
using SGAS.Domain.Notifications;

namespace SGAS.Application
{
    public class ServicoApp : IServicoApp
    {

        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IServicoQueryRepository _query;

        public ServicoApp(IMapper mapper, 
                         IMediatorHandler mediatorHandler, 
                         IServicoQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<ServicoNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<ServicoNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Servico> Register(ServicoViewModel request)
        {
            var command = _mapper.Map<ServicoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Servico>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new ServicoDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Servico> Update(ServicoViewModel request)
        {
            var command = _mapper.Map<ServicoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Servico>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
