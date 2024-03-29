using FluentValidation.Results;
using SGAS.Domain.Interfaces.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using SGAS.Domain.Entity;
using AutoMapper;
using SGAS.Domain.Notifications;

namespace SGAS.Domain.Command

{
    public class MotivoCommandHandler : CommandHandler,
        IRequestHandler<MotivoCreateCommand, Motivo>,
        IRequestHandler<MotivoUpdateCommand, Motivo>,
        IRequestHandler<MotivoDeleteCommand, ValidationResult>
    {

        private readonly IMotivoRepository _repository;
        private readonly IMapper _mapper;

        public MotivoCommandHandler(IMotivoRepository repository,
                                    IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Motivo> Handle(MotivoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Motivo>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<MotivoCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Motivo> Handle(MotivoUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Motivo>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<MotivoUpdateNotification>(objeto));

            //  await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(MotivoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<MotivoDeleteNotification>(response));

            // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
