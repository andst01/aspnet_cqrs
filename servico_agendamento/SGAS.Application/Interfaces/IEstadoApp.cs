using SGAS.Application.Interfaces.Base;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;

namespace SGAS.Application.Interfaces
{
    public interface IEstadoApp : IQueryBase<EstadoViewModel, EstadoNotification>,
                                   IActionBase<EstadoViewModel, Estado>
    {
    }
}
