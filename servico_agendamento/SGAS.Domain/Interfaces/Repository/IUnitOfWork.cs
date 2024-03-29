using SGAS.Domain.Interfaces.RepositoryMongo.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SGAS.Domain.Interfaces.Mediator;

namespace SGAS.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        IMediatorHandler mediatorHandler { get; }

        IAgendaRepository agendaRepository { get; }

        IAgendamentoRepository agendamentoRepository { get; }

        IFuncaoRepository aspNetRoleRepository { get; }

        IUsuarioRepository aspNetUserRepository { get; }

        IFuncaoUsuarioRepository aspNetUserRoleRepository { get; }

        ICargoRepository cargoRepository { get; }

        ICargoFuncionarioRepository cargoFuncionarioRepository { get; }

        ICepRepository cepRepository { get; }

        ICidadeRepository cidadeRepository { get; }

        IClienteRepository clienteRepository { get; }

        IEmpresaRepository empresaRepository { get; }

        IEnderecoRepository enderecoRepository { get; }

        IFornecedorRepository fornecedorRepository { get; }

        IFuncionarioRepository funcionarioRepository { get; }

        IMesoRegiaoRepository mesoRegiaoRepository { get; }

        IMicroRegiaoRepository microRegiaoRepository { get; }

        IMotivoRepository motivoRepository { get; }

        IPessoaRepository pessoaRepository { get; }

        IRegiaoRepository regiaoRepository { get; }

        IServicoRepository servicoRepository { get; }

        IEstadoRepository ufRepository { get; }

        IUnidadeVendaRepository unidadeVendaRepository { get; }

        IHistoricoEventoRepository historicoEventoRepository { get; }

        
    }
}
