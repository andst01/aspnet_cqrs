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
    public class CidadeApp :  ICidadeApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly ICidadeQueryRepository _query;

        public CidadeApp(IMapper mapper, 
                        IMediatorHandler mediatorHandler, 
                        ICidadeQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<CidadeNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<CidadeNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public  async Task<Cidade> Register(CidadeViewModel request)
        {
            var command = _mapper.Map<CidadeCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Cidade>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new CidadeCreateCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Cidade> Update(CidadeViewModel request)
        {
            var command = _mapper.Map<CidadeUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Cidade>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
