using AutoMapper;
using FluentValidation.Results;
using MediatR;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Domain.Notifications;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Command
{
    public class EstadoCommandHandler : CommandHandler,
          IRequestHandler<EstadoCreateCommand, Estado>,
          IRequestHandler<EstadoUpdateCommand, Estado>,
          IRequestHandler<EstadoDeleteCommand, ValidationResult>
    {

        private readonly IEstadoRepository _repository;
        private readonly IMapper _mapper;

        public EstadoCommandHandler(IEstadoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Estado> Handle(EstadoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Estado>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<EstadoCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Estado> Handle(EstadoUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Estado>(request);

            if (!request.IsValid()) return objeto;

            var response =  _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<EstadoUpdateNotification>(response));

            //await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(EstadoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _mapper.Map<Estado>(request);

            var response = _repository.ObterPorId(request.Id);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            _repository.Excluir(response);

            response.AddDomainEvent(_mapper.Map<EstadoDeleteNotification>(response));

            //await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
