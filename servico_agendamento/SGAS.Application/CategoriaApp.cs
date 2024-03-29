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
    public class CategoriaApp : ICategoriaApp
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaQueryRepository _query;
        private readonly IMediatorHandler _mediatorHandler;

        public CategoriaApp(IMapper mapper, 
                            ICategoriaQueryRepository query, 
                            IMediatorHandler mediatorHandler)
        {
            _mapper = mapper;
            _query = query;
            _mediatorHandler = mediatorHandler;
        }

        public async Task<IEnumerable<CategoriaNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<CategoriaNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Categoria> Register(CategoriaViewModel request)
        {
            var command = _mapper.Map<CategoriaCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Categoria>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new CategoriaDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Categoria> Update(CategoriaViewModel request)
        {
            var command = _mapper.Map<CategoriaUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Categoria>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
