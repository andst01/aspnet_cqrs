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
    public class UnidadeVendaCommandHandler : CommandHandler,
                                              IRequestHandler<UnidadeVendaCreateCommand, UnidadeVenda>,
                                              IRequestHandler<UnidadeVendaUpdateCommand, UnidadeVenda>,
                                              IRequestHandler<UnidadeVendaDeleteCommand, ValidationResult>
    {
        private readonly IUnidadeVendaRepository _repository;
        private readonly IMapper _mapper;

        public UnidadeVendaCommandHandler(IUnidadeVendaRepository repository,
                                          IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UnidadeVenda> Handle(UnidadeVendaCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<UnidadeVenda>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<UnidadeVendaCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<UnidadeVenda> Handle(UnidadeVendaUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<UnidadeVenda>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<UnidadeVendaUpdateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(UnidadeVendaDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<UnidadeVendaDeleteNotification>(response));

            //  await PublisEvent(_repository);

            return response.ValidationResult;
        }


    }
}
