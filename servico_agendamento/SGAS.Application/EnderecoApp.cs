using AutoMapper;
using FluentValidation.Results;
using SGAS.Application.Base;
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
    public class EnderecoApp : IEnderecoApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IEnderecoQueryRepository _query;

        public EnderecoApp(IMapper mapper, 
                          IMediatorHandler mediatorHandler, 
                          IEnderecoQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<EnderecoNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<EnderecoNotification> GetById(int id)
        {
           return await _query.GetById(id);
        }

        public async Task<Endereco> Register(EnderecoViewModel request)
        {
            var command = _mapper.Map<EnderecoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Endereco>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new EnderecoDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Endereco> Update(EnderecoViewModel request)
        {
            var command = _mapper.Map<EnderecoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Endereco>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
