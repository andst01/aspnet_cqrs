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
    public class ProdutoCommandHandler : CommandHandler,
                                        IRequestHandler<ProdutoCreateCommand, Produto>,
                                        IRequestHandler<ProdutoUpdateCommand, Produto>,
                                        IRequestHandler<ProdutoDeleteCommand, ValidationResult>

    {

        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ProdutoCommandHandler(IProdutoRepository repository,
                                     IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Produto> Handle(ProdutoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Produto>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.AddDomainEvent(_mapper.Map<ProdutoCreateNotification>(request));

            response.ValidationResult = await Commit(_repository);

            return response;
        }

        public async Task<Produto> Handle(ProdutoUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Produto>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.AddDomainEvent(_mapper.Map<ProdutoUpdateNotification>(request));

            response.ValidationResult = await Commit(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(ProdutoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _repository.ObterPorId(request.Id);

            objeto.AddDomainEvent(_mapper.Map<ProdutoDeleteNotification>(objeto));

            _repository.Excluir(objeto);

            return await Commit(_repository);
        }
    }
}
