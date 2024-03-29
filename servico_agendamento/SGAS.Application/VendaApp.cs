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
    public class VendaApp : IVendaApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IVendaQueryRepository _query;

        public VendaApp(IMapper mapper, 
                        IMediatorHandler mediatorHandler, 
                        IVendaQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<VendaNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<VendaNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Venda> Register(VendaViewModel request)
        {
            var command = _mapper.Map<VendaCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Venda>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new VendaDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Venda> Update(VendaViewModel request)
        {
            var command = _mapper.Map<VendaUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Venda>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
