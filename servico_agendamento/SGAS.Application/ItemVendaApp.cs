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
    public class ItemVendaApp : IItemVendaApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IItemVendaQueryRepository _query;

        public ItemVendaApp(IMapper mapper,
                            IMediatorHandler mediatorHandler,
                            IItemVendaQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<ItemVendaNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<ItemVendaNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<ItemVenda> Register(ItemVendaViewModel request)
        {
            var command = _mapper.Map<ItemVendaCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<ItemVenda>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public Task<ValidationResult> Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ItemVenda> Update(ItemVendaViewModel request)
        {
            throw new System.NotImplementedException();
        }
    }
}
