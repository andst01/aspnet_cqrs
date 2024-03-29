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
    public class EstadoApp :  IEstadoApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IEstadoQueryRepository _query;

        public EstadoApp(IMapper mapper, 
                         IMediatorHandler mediatorHandler, 
                         IEstadoQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<EstadoNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<EstadoNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Estado> Register(EstadoViewModel request)
        {
            var command = _mapper.Map<EstadoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Estado>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new EstadoDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Estado> Update(EstadoViewModel request)
        {
            var command = _mapper.Map<EstadoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Estado>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
