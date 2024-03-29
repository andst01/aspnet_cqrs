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
    public class FornecedorCommandHandler : CommandHandler,
         IRequestHandler<FornecedorCreateCommand, Fornecedor>,
         IRequestHandler<FornecedorUpdateCommand, Fornecedor>,
         IRequestHandler<FornecedorDeleteCommand, ValidationResult>
    {
        private readonly IFornecedorRepository _repository;
        private readonly IMapper _mapper;

        public FornecedorCommandHandler(IFornecedorRepository repository,
                                        IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Fornecedor> Handle(FornecedorCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Fornecedor>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<FornecedorCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Fornecedor> Handle(FornecedorUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Fornecedor>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<FornecedorUpdateNotification>(response));

            //  await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(FornecedorDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _repository.ObterPorId(request.Id);

            _repository.Excluir(objeto);

            objeto.ValidationResult = await Commit(_repository);

            if (objeto.ValidationResult.IsValid) return objeto.ValidationResult;

            objeto.AddDomainEvent(_mapper.Map<FornecedorDeleteNotification>(objeto));

            // await PublisEvent(_repository);

            return objeto.ValidationResult;
        }
    }
}
