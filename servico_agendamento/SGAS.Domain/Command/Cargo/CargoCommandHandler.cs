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
    public class CargoCommandHandler : CommandHandler,
        IRequestHandler<CargoCreateCommand, Cargo>,
        IRequestHandler<CargoUpdateCommand, Cargo>,
        IRequestHandler<CargoDeleteCommand, ValidationResult>
    {
        private readonly ICargoRepository _repository;
        private readonly IMapper _mapper;

        public CargoCommandHandler(ICargoRepository repository,
                                   IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Cargo> Handle(CargoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Cargo>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<CargoCreateNotification>(response));

            //await PublisEvent(_repository);

            return response;
        }

        public async Task<Cargo> Handle(CargoUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Cargo>(request);

            if (!request.IsValid()) return objeto;

            // var entidade = _repository.ObterPorId(objeto.Id);

            var response = _repository.Atualizar(x => x.Id == request.Id, objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<CargoUpdateNotification>(response));

           // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(CargoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _mapper.Map<Cargo>(request);

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<CargoDeleteNotification>(response));

            //await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
