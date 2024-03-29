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
    public class PessoaCommandHandler : CommandHandler,
                                        IRequestHandler<PessoaCreateCommand, Pessoa>,
                                        IRequestHandler<PessoaUpdateCommand, Pessoa>,
                                        IRequestHandler<PessoaDeleteCommand, ValidationResult>
    {

        private readonly IPessoaRepository _repository;
        private readonly IMapper _mapper;

        public PessoaCommandHandler(IPessoaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Pessoa> Handle(PessoaCreateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Pessoa>(((PessoaCommand)request));

            if (!request.IsValid()) return objeto;

            var response = await _repository.AdicionarPessoaFuncionario(objeto);
            // var response = _repository.Adicionar(objeto);

            response.ValidationResult = await Commit(_repository);

            if(!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<PessoaCreateNotification>(response));

            // await PublisEvent(_repository);

            return response;
        }

        public async Task<Pessoa> Handle(PessoaUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Pessoa>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<PessoaUpdateNotification>(response));

            //  await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(PessoaDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<PessoaDeleteNotification>(response));

            //  await PublisEvent(_repository);

            return response.ValidationResult;
        }
    }
}
