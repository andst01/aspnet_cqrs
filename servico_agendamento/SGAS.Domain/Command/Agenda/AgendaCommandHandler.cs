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
    public class AgendaCommandHandler : CommandHandler,
        IRequestHandler<AgendaCreateCommand, Agenda>,
        IRequestHandler<AgendaUpdateCommand, Agenda>,
        IRequestHandler<AgendaDeleteCommand, ValidationResult>
    {

        private readonly IAgendaRepository _repository;
        private readonly IMapper _mapper;



        public AgendaCommandHandler(IAgendaRepository repository,
                                    IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Agenda> Handle(AgendaUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Agenda>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<AgendaCreateNotification>(objeto));

            //await PublisEvent(_repository);

            return response;
        }

        public async Task<Agenda> Handle(AgendaCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Agenda>(request);

            if (!request.IsValid()) return objeto;
          
            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<AgendaUpdateNotification>(objeto));

           // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(AgendaDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _repository.ObterPorId(request.Id);

            objeto.AddDomainEvent(_mapper.Map<AgendaDeleteNotification>(objeto));

            _repository.Excluir(objeto);

            objeto.ValidationResult = await Commit(_repository);

            if (!objeto.ValidationResult.IsValid) return objeto.ValidationResult;

            //await PublisEvent(_repository);

            return objeto.ValidationResult;
        }
    }
}
