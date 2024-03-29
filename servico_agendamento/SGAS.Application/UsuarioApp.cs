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
    public class UsuarioApp : IUsuarioApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IUsuarioQueryRepository _query;

        public UsuarioApp(IMapper mapper, 
                          IMediatorHandler mediatorHandler, 
                          IUsuarioQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<UsuarioNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<UsuarioNotification> GetById(int id)
        {
            return await _query.GetById(id);    
        }

        public async Task<Usuario> Register(UsuarioViewModel request)
        {
            var command = _mapper.Map<UsuarioCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Usuario>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new UsuarioDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Usuario> Update(UsuarioViewModel request)
        {
            var command = _mapper.Map<UsuarioUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Usuario>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
