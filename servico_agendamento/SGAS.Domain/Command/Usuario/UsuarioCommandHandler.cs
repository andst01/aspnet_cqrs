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
    public class UsuarioCommandHandler : CommandHandler,
        IRequestHandler<UsuarioCreateCommand, Usuario>,
        IRequestHandler<UsuarioUpdateCommand, Usuario>,
        IRequestHandler<UsuarioDeleteCommand, ValidationResult>
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _repository;

        public UsuarioCommandHandler(IUsuarioRepository repository,
                                        IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Usuario> Handle(UsuarioCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Usuario>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<UsuarioCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Usuario> Handle(UsuarioUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Usuario>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<UsuarioUpdateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(UsuarioDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<UsuarioDeleteNotification>(response));

            return response.ValidationResult;
        }
    }
}
