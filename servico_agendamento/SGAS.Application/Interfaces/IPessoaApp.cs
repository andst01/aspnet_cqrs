using SGAS.Application.Interfaces.Base;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;

namespace SGAS.Application.Interfaces
{
    public interface IPessoaApp : IQueryBase<PessoaViewModel, PessoaNotification>,
                                  IActionBase<PessoaViewModel, Pessoa>
    {
    }
}
