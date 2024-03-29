using FluentValidation.Results;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using SGAS.Domain.Notifications;

namespace SGAS.Domain.Command
{
    public class ServicoCommandHandler : CommandHandler,
        IRequestHandler<ServicoCreateCommand, Servico>,
        IRequestHandler<ServicoUpdateCommand, Servico>,
        IRequestHandler<ServicoDeleteCommand, ValidationResult>
    {

        private readonly IServicoRepository _repository;
        private readonly IMapper _mapper;


        public ServicoCommandHandler(IServicoRepository repository,
                                     IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Servico> Handle(ServicoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Servico>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<ServicoCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Servico> Handle(ServicoUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Servico>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<ServicoUpdateNotification>(objeto));

            // await PublisEvent(_repository);

            return response;
        }



        public async Task<ValidationResult> Handle(ServicoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _repository.ObterPorId(request.Id);

            _repository.Excluir(objeto);

            objeto.AddDomainEvent(_mapper.Map<ServicoDeleteNotification>(objeto));

            return await Commit(_repository);
        }
    }
}
