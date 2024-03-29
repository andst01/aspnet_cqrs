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
    public class CepCommandHandler
        : CommandHandler,
         IRequestHandler<CepCreateCommand, Cep>,
         IRequestHandler<CepUpdateCommand, Cep>,
         IRequestHandler<CepDeleteCommand, ValidationResult>

    {

        private readonly ICepRepository _repository;
        private readonly IMapper _mapper;
        public CepCommandHandler(ICepRepository cepRepository,
                                 IMapper mapper)
        {
            _repository = cepRepository;
            _mapper = mapper;
        }

        public async Task<Cep> Handle(CepCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Cep>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<CepCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Cep> Handle(CepUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Cep>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<CepUpdateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(CepDeleteCommand request, CancellationToken cancellationToken)
        {

            //https://servicodados.ibge.gov.br/api/v1/localidades/regioes
            //https://servicodados.ibge.gov.br/api/v1/localidades/regioes/4/municipios

            if (!request.IsValid()) return request.ValidationResult;

            var objeto = _repository.ObterPorId(request.Id);

            _repository.Excluir(objeto);

            objeto.ValidationResult = await Commit(_repository);

            if (!objeto.ValidationResult.IsValid) return objeto.ValidationResult;

            objeto.AddDomainEvent(_mapper.Map<CepDeleteNotification>(objeto));

            // await PublisEvent(_repository);

            return objeto.ValidationResult;
        }
    }
}
