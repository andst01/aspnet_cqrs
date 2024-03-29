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
    public class EmpresaCommandHandler : CommandHandler,
        IRequestHandler<EmpresaCreateCommand, Empresa>,
        IRequestHandler<EmpresaUpdateCommand, Empresa>,
        IRequestHandler<EmpresaDeleteCommand, ValidationResult>
    {

        private readonly IEmpresaRepository _repository;
        private readonly IMapper _mapper;

        public EmpresaCommandHandler(IEmpresaRepository repository,
                                     IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Empresa> Handle(EmpresaCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Empresa>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if(!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<EmpresaCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Empresa> Handle(EmpresaUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Empresa>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<EmpresaUpdateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(EmpresaDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<EmpresaDeleteNotification>(response));

            // await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
