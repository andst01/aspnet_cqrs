using SGAS.Domain.Interfaces.Repository;
using SGAS.Domain.Interfaces.RepositoryMongo.Base;
using System;
using System.Collections.Generic;
using System.Text;
using SGAS.Infra.Context;
using SGAS.Domain.Interfaces.Mediator;

namespace SGAS.Infra.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

      

        public IMediatorHandler mediatorHandler { get; }

        public IHistoricoEventoRepository historicoEventoRepository { get; }

        public IAgendaRepository agendaRepository { get; }

        public IAgendamentoRepository agendamentoRepository { get; }

        public IFuncaoRepository aspNetRoleRepository { get; }

        public IUsuarioRepository aspNetUserRepository { get; }

        public IFuncaoUsuarioRepository aspNetUserRoleRepository { get; }

        public ICargoRepository cargoRepository { get; }

        public ICargoFuncionarioRepository cargoFuncionarioRepository { get; }

        public ICepRepository cepRepository { get; }

        public ICidadeRepository cidadeRepository { get; }

        public IClienteRepository clienteRepository { get; }

        public IEmpresaRepository empresaRepository { get; }

        public IEnderecoRepository enderecoRepository { get; }

        public IFornecedorRepository fornecedorRepository { get; }

        public IFuncionarioRepository funcionarioRepository { get; }

        public IMesoRegiaoRepository mesoRegiaoRepository { get; }

        public IMicroRegiaoRepository microRegiaoRepository { get; }

        public IMotivoRepository motivoRepository { get; }

        public IPessoaRepository pessoaRepository { get; }

        public IRegiaoRepository regiaoRepository { get; }

        public IServicoRepository servicoRepository { get; }

        public IEstadoRepository ufRepository { get; }

        public IUnidadeVendaRepository unidadeVendaRepository { get; }
    }
}
