using FluentValidation.Results;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using SGAS.Domain.Command;

namespace SGAS.Domain.Notifications
{
    public class ItemServicoCommandHandler : CommandHandler,
        IRequestHandler<ItemServicoCreateCommand, ValidationResult>,
        IRequestHandler<ItemServicoUpdateCommand, ValidationResult>,
        IRequestHandler<ItemServicoDeleteCommand, ValidationResult>
    {

        private readonly IItemServicoRepository _repository;

        public ItemServicoCommandHandler(IItemServicoRepository repository)
        {
            _repository = repository;
        }

        public async Task<ValidationResult> Handle(ItemServicoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var itemServico = new ItemServico(request.Id, request.IdProduto, request.Descricao, request.Quantidade, request.PrecoUnitario, request.ValorItem, request.ValorDesconto, request.IdServico);

            itemServico.AddDomainEvent(new ItemServicoCreateEvent(request.Id, request.IdProduto, request.Descricao, request.Quantidade, request.PrecoUnitario, request.ValorItem, request.ValorDesconto, request.IdServico));

            _repository.Adicionar(itemServico);

            return await Commit(_repository);
        }

        public async Task<ValidationResult> Handle(ItemServicoUpdateCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var itemServico = new ItemServico(request.Id, request.IdProduto, request.Descricao, request.Quantidade, request.PrecoUnitario, request.ValorItem, request.ValorDesconto, request.IdServico);

            itemServico.AddDomainEvent(new ItemServicoUpdateEvent(request.Id, request.IdProduto, request.Descricao, request.Quantidade, request.PrecoUnitario, request.ValorItem, request.ValorDesconto, request.IdServico));

            _repository.Atualizar(itemServico);

            return await Commit(_repository);
        }

        public async Task<ValidationResult> Handle(ItemServicoCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
