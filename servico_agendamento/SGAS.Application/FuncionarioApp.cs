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
    public class FuncionarioApp : IFuncionarioApp
    {
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IFuncionarioQueryRepository _query;
        private readonly IMapper _mapper;

        public FuncionarioApp(IMediatorHandler mediatorHandler, 
                              IFuncionarioQueryRepository query, 
                              IMapper mapper)
        {
            _mediatorHandler = mediatorHandler;
            _query = query;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FuncionarioNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<FuncionarioNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Funcionario> Register(FuncionarioViewModel request)
        {
            var command = _mapper.Map<FuncionarioCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Funcionario>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new FuncionarioDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Funcionario> Update(FuncionarioViewModel request)
        {
            var command = _mapper.Map<FuncionarioUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Funcionario>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
