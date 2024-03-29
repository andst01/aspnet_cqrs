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
    public class FuncaoUsuarioApp : IFuncaoUsuarioApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IFuncaoUsuarioQueryRepository _query;

        public FuncaoUsuarioApp(IMapper mapper, 
                                IMediatorHandler mediatorHandler, 
                                IFuncaoUsuarioQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<FuncaoUsuarioNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<FuncaoUsuarioNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<FuncaoUsuario> Register(FuncaoUsuarioViewModel request)
        {
            var command = _mapper.Map<FuncaoUsuarioCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<FuncaoUsuario>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int roleId, int userId)
        {

            var response = await _mediatorHandler.SendCommand(new FuncaoUsuarioDeleteCommand() { RoleId = roleId, UserId = userId });
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;

        }

        public async Task<ValidationResult> Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<FuncaoUsuario> Update(FuncaoUsuarioViewModel request)
        {
            var command = _mapper.Map<FuncaoUsuarioUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<FuncaoUsuario>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
