using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAgendamento.Domain.Interfaces.Services
{
    public interface IUnitOfWorkService : IDisposable
    {
        IAgendamentoService AgendamentoService{ get; }

        IAgendaService AgendaService { get; }

        IItemServicoService ItemServicoService { get; }

        IMotivoService MotivoService { get; }

        IServicoService ServicoService { get; }

        void Salvar();

        Task SalvarAsync();
    }
}
