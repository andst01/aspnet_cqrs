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
    public class MesoRegiaoCommandHandler : CommandHandler,
          IRequestHandler<MesoRegiaoCreateCommand, MesoRegiao>,
          IRequestHandler<MesoRegiaoUpdateCommand, MesoRegiao>,
          IRequestHandler<MesoRegiaoDeleteCommand, ValidationResult>
    {
        private readonly IMesoRegiaoRepository _repository;
        private readonly IMapper _mapper;

        public MesoRegiaoCommandHandler(IMesoRegiaoRepository repository,
                                        IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<MesoRegiao> Handle(MesoRegiaoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<MesoRegiao>(request);

            if (!request.IsValid()) return objeto;
            
            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<MesoRegiaoCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<MesoRegiao> Handle(MesoRegiaoUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<MesoRegiao>(request);

            if (!request.IsValid()) return objeto;
        
            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<MesoRegiaoUpdateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(MesoRegiaoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;
           
            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<MesoRegiaoDeleteNotification>(response));

            // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
