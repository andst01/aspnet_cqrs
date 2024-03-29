namespace SGAS.Application.Interfaces
{
    public interface IUnitOfWorkApp 
    {
        IAgendamentoApp AgendamentoApp { get; }

        IAgendaApp AgendaApp{ get; }

        ICepApp CepApp { get; }

        ICidadeApp CidadeApp { get; }

        IClienteApp ClienteApp { get; }

        IEnderecoApp EnderecoApp { get; }

        IMesoRegiaoApp MesoRegiaoApp { get; }

        IMicroRegiaoApp MicroRegiaoApp { get; }

        IMotivoApp MotivoApp { get; }

        IRegiaoApp RegiaoApp { get; }

        IServicoApp ServicoApp { get; }

        IUfApp UfApp { get; }

        IUnidadeVendaApp UnidadeVendaApp { get; }


    }
}
