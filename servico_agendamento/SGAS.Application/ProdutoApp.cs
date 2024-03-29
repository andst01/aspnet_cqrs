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
    public class ProdutoApp : IProdutoApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IProdutoQueryRepository _query;

        public ProdutoApp(IMapper mapper, 
                          IMediatorHandler mediatorHandler, 
                          IProdutoQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<ProdutoNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<ProdutoNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Produto> Register(ProdutoViewModel request)
        {
            var command = _mapper.Map<ProdutoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Produto>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new ProdutoDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Produto> Update(ProdutoViewModel request)
        {
            var command = _mapper.Map<ProdutoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Produto>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
