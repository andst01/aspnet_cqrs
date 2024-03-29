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
    public class VendaCommandHandler : CommandHandler,
        IRequestHandler<VendaCreateCommand, Venda>,
        IRequestHandler<VendaUpdateCommand, Venda>,
        IRequestHandler<VendaDeleteCommand, ValidationResult>
    {

        private readonly IVendaRepository _repository;
        private readonly IMapper _mapper;

        public VendaCommandHandler(IVendaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Venda> Handle(VendaCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Venda>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<VendaCreateNotification>(response));

           // await PublisEvent(_repository);

            return response;
        }

        public async Task<Venda> Handle(VendaUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Venda>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<VendaCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(VendaDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            if (response == null)
            {
                AddError("A venda não existe");
                return ValidationResult;
            }

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<VendaDeleteNotification>(response));

            // await PublisEvent(_repository);

            return response.ValidationResult;

        }
    }
}
