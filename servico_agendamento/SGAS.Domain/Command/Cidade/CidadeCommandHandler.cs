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
    public class CidadeCommandHandler : CommandHandler,
         IRequestHandler<CidadeCreateCommand, Cidade>,
         IRequestHandler<CidadeUpdateCommand, Cidade>,
         IRequestHandler<CidadeDeleteCommand, ValidationResult>
    {

        private readonly ICidadeRepository _repository;
        private readonly IMapper _mapper;

        public CidadeCommandHandler(ICidadeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Cidade> Handle(CidadeCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Cidade>(request);

            if (!request.IsValid()) return objeto;
            
            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if(!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<CidadeCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Cidade> Handle(CidadeUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Cidade>(request);

            if (!request.IsValid()) return objeto;
            
            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<CidadeUpdateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(CidadeDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<CidadeDeleteNotification>(response));

            // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
