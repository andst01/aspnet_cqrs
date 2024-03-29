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
    public class FuncaoApp : IFuncaoApp
    {

        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IFuncaoQueryRepository _query;

        public FuncaoApp(IMapper mapper, 
                        IMediatorHandler mediatorHandler, 
                        IFuncaoQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<FuncaoNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<FuncaoNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Funcao> Register(FuncaoViewModel request)
        {
            var command = _mapper.Map<FuncaoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Funcao>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new FuncaoDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Funcao> Update(FuncaoViewModel request)
        {
            var command = _mapper.Map<FuncaoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Funcao>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
