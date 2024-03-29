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
    public class PessoaApp : IPessoaApp
    {

        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IPessoaQueryRepository _query;

        public PessoaApp(IMapper mapper, 
                        IMediatorHandler mediatorHandler, 
                        IPessoaQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<PessoaNotification>> GetAll()
        {
           return await _query.GetAll();
        }

        public async Task<PessoaNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Pessoa> Register(PessoaViewModel request)
        {
            var command = _mapper.Map<PessoaCommand>(request);
            var response = await _mediatorHandler.SendCommand<Pessoa>(command.ToCreate());
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new PessoaDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Pessoa> Update(PessoaViewModel request)
        {
            var command = _mapper.Map<PessoaCommand>(request);
            var response = await _mediatorHandler.SendCommand<Pessoa>(command.ToUpdate());
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
