using FluentValidation.Results;
using MediatR;
using SGAS.Domain.Entity;
using System.Threading.Tasks;
using System.Threading;
using AutoMapper;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Domain.Notifications;

namespace SGAS.Domain.Command
{
    public class CategoriaCommandHandler : CommandHandler,
         IRequestHandler<CategoriaCreateCommand, Categoria>,
         IRequestHandler<CategoriaUpdateCommand, Categoria>,
         IRequestHandler<CategoriaDeleteCommand, ValidationResult>
    {

        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;


        public CategoriaCommandHandler(ICategoriaRepository repository,
                                       IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Categoria> Handle(CategoriaCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Categoria>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<CategoriaCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Categoria> Handle(CategoriaUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Categoria>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<CategoriaUpdateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(CategoriaDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            response.AddDomainEvent(_mapper.Map<CategoriaDeleteNotification>(response));

            // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
