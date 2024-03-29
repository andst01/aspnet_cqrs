using AutoMapper;
using FluentValidation.Results;
using MediatR;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Domain.Notifications;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Command
{
    public class MicroRegiaoCommandHandler : CommandHandler,
          IRequestHandler<MicroRegiaoCreateCommand, MicroRegiao>,
          IRequestHandler<MicroRegiaoUpdateCommand, MicroRegiao>,
          IRequestHandler<MicroRegiaoDeleteCommand, ValidationResult>
    {

        private readonly IMicroRegiaoRepository _repository;
        private readonly IMapper _mapper;

        public MicroRegiaoCommandHandler(IMicroRegiaoRepository repository,
                                         IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<MicroRegiao> Handle(MicroRegiaoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<MicroRegiao>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<MicroRegiaoCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<MicroRegiao> Handle(MicroRegiaoUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<MicroRegiao>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<MicroRegiaoUpdateNotification>(response));

            //  await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(MicroRegiaoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _mapper.Map<MicroRegiao>(request);

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<MicroRegiaoCreateNotification>(objeto));

            // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
