using AutoMapper;
using FluentValidation.Results;
using MediatR;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Domain.Notifications;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Command
{
    public class ItemVendaCommandHandler : CommandHandler,
        IRequestHandler<ItemVendaCreateCommand, ItemVenda>,
        IRequestHandler<ItemVendaUpdateCommand, ItemVenda>,
        IRequestHandler<ItemVendaDeleteCommand, ValidationResult>
    {

        private readonly IItemVendaRepository _repository;
        private readonly IMapper _mapper;

        public ItemVendaCommandHandler(IItemVendaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ItemVenda> Handle(ItemVendaCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<ItemVenda>(request);

            if (!request.IsValid()) return objeto;

            var retorno = _repository.Adicionar(objeto);

            retorno.ValidationResult = await Commit(_repository);

            if(!retorno.ValidationResult.IsValid) return retorno;

            retorno.AddDomainEvent(_mapper.Map<ItemVendaCreateNotification>(retorno));

            // await PublisEvent(_repository);

            return retorno;
        }

        public async Task<ItemVenda> Handle(ItemVendaUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<ItemVenda>(request);

            if (!request.IsValid()) return objeto;

            var retorno = _repository.Atualizar(objeto);

            retorno.ValidationResult = await Commit(_repository);

            if (!retorno.ValidationResult.IsValid) return retorno;

            retorno.AddDomainEvent(_mapper.Map<ItemVendaUpdateNotification>(retorno));

            // await PublisEvent(_repository);

            return retorno;
        }

        public async Task<ValidationResult> Handle(ItemVendaDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<ItemVendaDeleteNotification>(response));

            // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
