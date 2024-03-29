using SGAS.Application.Interfaces.Base;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;

namespace SGAS.Application.Interfaces
{
    public interface IRegiaoApp : IQueryBase<RegiaoViewModel, RegiaoNotification>,
                                   IActionBase<RegiaoViewModel, Regiao>
    {

    }
}
