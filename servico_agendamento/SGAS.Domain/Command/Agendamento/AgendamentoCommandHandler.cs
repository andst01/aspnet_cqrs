using FluentValidation.Results;
using SGAS.Domain.Interfaces.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;

namespace SGAS.Domain.Command
{

    public class AgendamentoCommandHandler : CommandHandler,
        IRequestHandler<AgendamentoCreateCommand, Agendamento>,
        IRequestHandler<AgendamentoUpdateCommand, Agendamento>,
        IRequestHandler<AgendamentoDeleteCommand, ValidationResult>
    {

        private readonly IAgendamentoRepository _repository;
        private readonly IMapper _mapper;

        public AgendamentoCommandHandler(IAgendamentoRepository repository,
                                         IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Agendamento> Handle(AgendamentoCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Agendamento>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<AgendamentoCreateNotification>(response));

           // await PublisEvent(_repository);

            return response;
        }

        public async Task<Agendamento> Handle(AgendamentoUpdateCommand request, CancellationToken cancellationToken)
        {

            var objeto = _mapper.Map<Agendamento>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<AgendamentoUpdateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(AgendamentoDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _repository.ObterPorId(request.Id);

            if (objeto == null)
            {
                AddError("O agendamento não existe");
                return ValidationResult;
            }

            _repository.Excluir(objeto);

            objeto.ValidationResult = await Commit(_repository);

            if (!objeto.ValidationResult.IsValid) return objeto.ValidationResult;

            objeto.AddDomainEvent(_mapper.Map<AgendamentoDeleteNotification>(objeto));

           // await PublisEvent(_repository);

            return objeto.ValidationResult;

        }
    }
}
