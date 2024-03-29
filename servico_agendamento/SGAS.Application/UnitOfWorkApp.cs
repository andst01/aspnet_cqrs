using SGAS.Application.Interfaces;

namespace SGAS.Application
{
    public class UnitOfWorkApp : IUnitOfWorkApp
    {

        public IAgendamentoApp AgendamentoApp { get; }

        public IAgendaApp AgendaApp { get; }

        public IMotivoApp MotivoApp { get; }

        public IServicoApp ServicoApp { get; }

        public ICepApp CepApp { get; }

        public ICidadeApp CidadeApp { get; }

        public IClienteApp ClienteApp { get; }

        public IEnderecoApp EnderecoApp { get; }

        public IMesoRegiaoApp MesoRegiaoApp { get; }

        public IMicroRegiaoApp MicroRegiaoApp { get; }

        public IRegiaoApp RegiaoApp { get; }

        public IUfApp UfApp { get; }

        public IUnidadeVendaApp UnidadeVendaApp { get; }
    }
}
