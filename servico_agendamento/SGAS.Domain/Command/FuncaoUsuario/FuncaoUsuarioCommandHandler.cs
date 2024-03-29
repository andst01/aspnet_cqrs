using AutoMapper;
using FluentValidation.Results;
using MediatR;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Domain.Notifications;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Command
{
    public class FuncaoUsuarioCommandHandler : CommandHandler,
                 IRequestHandler<FuncaoUsuarioCreateCommand, FuncaoUsuario>,
                 IRequestHandler<FuncaoUsuarioUpdateCommand, FuncaoUsuario>,
                 IRequestHandler<FuncaoUsuarioDeleteCommand, ValidationResult>
    {

        private readonly IMapper _mapper;
        private readonly IFuncaoUsuarioRepository _repository;

        public FuncaoUsuarioCommandHandler(IMapper mapper, IFuncaoUsuarioRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<FuncaoUsuario> Handle(FuncaoUsuarioCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<FuncaoUsuario>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<FuncaoUsuarioCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<FuncaoUsuario> Handle(FuncaoUsuarioUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<FuncaoUsuario>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<FuncaoUsuarioUpdateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(FuncaoUsuarioDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _repository.ObterTodos().FirstOrDefault(x => x.RoleId == request.RoleId && x.UserId == request.RoleId);

            _repository.Excluir(objeto);

            objeto.ValidationResult = await Commit(_repository);

            if (!objeto.ValidationResult.IsValid) return objeto.ValidationResult;

            objeto.AddDomainEvent(_mapper.Map<FuncaoUsuarioDeleteNotification>(objeto));

            // await PublisEvent(_repository);

            return objeto.ValidationResult;
        }
    }
}
