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
    public class UnidadeVendaApp : IUnidadeVendaApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IUnidadeVendaQueryRepository _query;

        public UnidadeVendaApp(IMapper mapper,
                               IMediatorHandler mediatorHandler,
                               IUnidadeVendaQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<UnidadeVendaNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<UnidadeVendaNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<UnidadeVenda> Register(UnidadeVendaViewModel request)
        {
            var command = _mapper.Map<UnidadeVendaCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<UnidadeVenda>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;

        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new UnidadeVendaDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<UnidadeVenda> Update(UnidadeVendaViewModel request)
        {
            var command = _mapper.Map<UnidadeVendaUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<UnidadeVenda>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
