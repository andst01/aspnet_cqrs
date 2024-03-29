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
    public class RegiaoCommandHandler : CommandHandler,
          IRequestHandler<RegiaoCreateCommand, Regiao>,
          IRequestHandler<RegiaoUpdateCommand, Regiao>,
          IRequestHandler<RegiaoDeleteCommand, ValidationResult>
    {

        private readonly IRegiaoRepository _repository;
        private readonly IMapper _mapper;

        public RegiaoCommandHandler(IRegiaoRepository repository,
                                    IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Regiao> Handle(RegiaoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Regiao>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if(!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<RegiaoCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Regiao> Handle(RegiaoUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Regiao>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<RegiaoUpdateNotification>(objeto));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(RegiaoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<RegiaoUpdateNotification>(response));

           // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
