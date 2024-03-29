using AutoMapper;
using FluentValidation.Results;
using SGAS.Application.Interfaces;
using SGAS.Application.ViewModels;
using SGAS.Domain.Command;
using System.Collections.Generic;
using System.Threading.Tasks;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Mediator;
using SGAS.Domain.Notifications;

namespace SGAS.Application
{
    public class MotivoApp : IMotivoApp
    {

        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IMotivoQueryRepository _query;

        public MotivoApp(IMapper mapper, 
                         IMediatorHandler mediatorHandler, 
                         IMotivoQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<MotivoNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<MotivoNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Motivo> Register(MotivoViewModel request)
        {
            var command = _mapper.Map<MotivoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Motivo>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new MotivoDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Motivo> Update(MotivoViewModel request)
        {
            var command = _mapper.Map<MotivoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Motivo>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
