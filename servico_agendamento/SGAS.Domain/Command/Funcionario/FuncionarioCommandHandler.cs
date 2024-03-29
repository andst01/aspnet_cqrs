using AutoMapper;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Domain.Notifications;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SGAS.Domain.Command
{

    public class FuncionarioCommandHandler : CommandHandler,
                         IRequestHandler<FuncionarioCreateCommand, Funcionario>,
                         IRequestHandler<FuncionarioUpdateCommand, Funcionario>,
                         IRequestHandler<FuncionarioDeleteCommand, ValidationResult>
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IFuncionarioRepository _repository;
        private readonly IMapper _mapper;


        public FuncionarioCommandHandler(IFuncionarioRepository repository,
                                         IPessoaRepository pessoaRepository,
                                         IEnderecoRepository enderecoRepository,
                                         IMapper mapper)
        {
            _pessoaRepository = pessoaRepository;
            _enderecoRepository = enderecoRepository;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Funcionario> Handle(FuncionarioCreateCommand request, CancellationToken cancellationToken)
        {
            // mapRequest = request;
            var objeto = _mapper.Map<Funcionario>(((FuncionarioCommand)request));

            if (!request.IsValid() ||
                !((PessoaCreateCommand)request.Pessoa).IsValid() ||
                !request.Pessoa.Endereco.ToCreate().IsValid()) return objeto;

            //var pessoaResponse = _pessoaRepository.Adicionar(objeto.Pessoa);
            //var enderecoResponse = _enderecoRepository.Adicionar(objeto.Pessoa.Endereco);

            var response = await _repository.AdicionarEntidades(objeto);

            if (response != null) AddError("Erro ao Inserir Funcionario");

            response.ValidationResult = ValidationResult;

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<FuncionarioCreateNotification>(response));
            response.Pessoa.AddDomainEvent(_mapper.Map<PessoaCreateNotification>(response.Pessoa));
            response.Pessoa.Endereco.AddDomainEvent(_mapper.Map<EnderecoCreateNotification>(response.Pessoa.Endereco));

            // await PublisEvent(_repository);

            return response;

        }

        public async Task<Funcionario> Handle(FuncionarioUpdateCommand request, CancellationToken cancellationToken)
        {
            var objeto = _mapper.Map<Funcionario>(request);

            if (!request.IsValid()) return objeto;

            var response = _repository.Atualizar(objeto);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response;

            response.AddDomainEvent(_mapper.Map<FuncionarioUpdateNotification>(response));

            //await PublisEvent(_repository);

            return response;
        }

        public async Task<ValidationResult> Handle(FuncionarioDeleteCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var response = _repository.ObterPorId(request.Id);

            _repository.Excluir(response);

            response.ValidationResult = await Commit(_repository);

            if (!response.ValidationResult.IsValid) return response.ValidationResult;

            response.AddDomainEvent(_mapper.Map<FornecedorDeleteNotification>(request));

            // await PublisEvent(_repository);

            return response.ValidationResult;

        }

    }
}
