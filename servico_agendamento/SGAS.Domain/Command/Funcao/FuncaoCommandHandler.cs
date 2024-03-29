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
    public class FuncaoCommandHandler : CommandHandler,
        IRequestHandler<FuncaoCreateCommand, Funcao>,
        IRequestHandler<FuncaoUpdateCommand, Funcao>,
        IRequestHandler<FuncaoDeleteCommand, ValidationResult>

    {

        private readonly IFuncaoRepository _repository;
        private readonly IMapper _mapper;

        public FuncaoCommandHandler(IFuncaoRepository repository,
                                        IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Funcao> Handle(FuncaoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Funcao>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<FuncaoCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Funcao> Handle(FuncaoUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Funcao>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<FuncaoUpdateNotification>(response));

           // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(FuncaoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _repository.ObterPorId(request.Id);

            _repository.Excluir(objeto);

            objeto.ValidationResult = await Commit(_repository);

            if (!objeto.ValidationResult.IsValid) return objeto.ValidationResult;

            objeto.AddDomainEvent(_mapper.Map<FuncaoDeleteNotification>(objeto));

            // await PublisEvent(_repository);

            return objeto.ValidationResult;
        }
    }
}
