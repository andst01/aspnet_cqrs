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
    public class EnderecoCommandHandler : CommandHandler,
         IRequestHandler<EnderecoCreateCommand, Endereco>,
         IRequestHandler<EnderecoUpdateCommand, Endereco>,
         IRequestHandler<EnderecoDeleteCommand, ValidationResult>
    {

        private readonly IEnderecoRepository _repository;
        private readonly IMapper _mapper;

        public EnderecoCommandHandler(IEnderecoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Endereco> Handle(EnderecoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Endereco>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<EnderecoCreateNotification>(response));

            //await PublisEvent(_repository);

            return response;
        }

        public async Task<Endereco> Handle(EnderecoUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Endereco>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            objeto.AddDomainEvent(_mapper.Map<EnderecoUpdateNotification>(response));

            //await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(EnderecoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _mapper.Map<Endereco>(request);

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<EnderecoDeleteNotification>(response));

            // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
