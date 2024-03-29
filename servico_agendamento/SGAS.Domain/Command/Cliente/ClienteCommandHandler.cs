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
    public class ClienteCommandHandler : CommandHandler,
        IRequestHandler<ClienteCreateCommand, Cliente>,
        IRequestHandler<ClienteUpdateCommand, Cliente>,
        IRequestHandler<ClienteDeleteCommand, ValidationResult>
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteCommandHandler(IClienteRepository repository,
                                     IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Cliente> Handle(ClienteCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Cliente>(request);

            if (!request.IsValid()) return objeto;
           
            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if(!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<ClienteCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Cliente> Handle(ClienteUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Cliente>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<ClienteUpdateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(ClienteDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<ClienteDeleteNotification>(response));

            // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
