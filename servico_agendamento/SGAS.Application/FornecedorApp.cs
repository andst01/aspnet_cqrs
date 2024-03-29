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
    public class FornecedorApp :  IFornecedorApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IFornecedorQueryRepository _query;

        public FornecedorApp(IMapper mapper, 
                            IMediatorHandler mediatorHandler, 
                            IFornecedorQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<FornecedorNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<FornecedorNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Fornecedor> Register(FornecedorViewModel request)
        {
            var command = _mapper.Map<FornecedorCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Fornecedor>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new FornecedorDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Fornecedor> Update(FornecedorViewModel request)
        {
            var command = _mapper.Map<FornecedorUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Fornecedor>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
