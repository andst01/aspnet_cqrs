using AutoMapper;
using FluentValidation.Results;
using MediatR;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Domain.Notifications;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Command
{
    public class CargoFuncionarioCommandHandler : CommandHandler,
        IRequestHandler<CargoFuncionarioCreateCommand, CargoFuncionario>,
        IRequestHandler<CargoFuncionarioUpdateCommand, CargoFuncionario>,
        IRequestHandler<CargoFuncionarioDeleteCommand, ValidationResult>
    {

        private readonly ICargoFuncionarioRepository _repository;
        private readonly IMapper _mapper;

        public CargoFuncionarioCommandHandler(ICargoFuncionarioRepository repository,
                                              IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CargoFuncionario> Handle(CargoFuncionarioCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<CargoFuncionario>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<CargoFuncionarioCreateNotification>(response));

            //await PublisEvent(_repository);

            return response;
        }

        public async Task<CargoFuncionario> Handle(CargoFuncionarioUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<CargoFuncionario>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<CargoFuncionarioUpdateNotification>(response));

            //await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(CargoFuncionarioDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _mapper.Map<CargoFuncionario>(request);

            var response = _repository.ObterPorId(objeto.Id);

            _repository.Excluir(objeto);

            response.ValidationResult = await Commit(_repository);

            if(!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<CargoFuncionarioDeleteNotification>(response));

            // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
