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
    public class MesoRegiaoApp : IMesoRegiaoApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IMesoRegiaoQueryRepository _query;

        public MesoRegiaoApp(IMapper mapper,
                            IMediatorHandler mediatorHandler,
                            IMesoRegiaoQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<MesoRegiaoNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<MesoRegiaoNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<MesoRegiao> Register(MesoRegiaoViewModel request)
        {
            var command = _mapper.Map<MesoRegiaoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<MesoRegiao>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new MesoRegiaoDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<MesoRegiao> Update(MesoRegiaoViewModel request)
        {
            var command = _mapper.Map<MesoRegiaoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<MesoRegiao>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
