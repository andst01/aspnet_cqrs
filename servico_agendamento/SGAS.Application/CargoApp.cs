using AutoMapper;
using FluentValidation.Results;
using SGAS.Application.Interfaces;
using SGAS.Application.ViewModels;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Mediator;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGAS.Application
{
    public class CargoApp :  ICargoApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly ICargoQueryRepository _query;
       

        public CargoApp(IMapper mapper, 
                        IMediatorHandler mediatorHandler, 
                        ICargoQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<CargoNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<CargoNotification> GetById(int id)
        {
            return await _query.GetById(id);
        }

        public async Task<Cargo> Register(CargoViewModel request)
        {
            var command = _mapper.Map<CargoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Cargo>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new CargoDeleteCommand() { Id = id });
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<Cargo> Update(CargoViewModel request)
        {
            var command = _mapper.Map<CargoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<Cargo>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
