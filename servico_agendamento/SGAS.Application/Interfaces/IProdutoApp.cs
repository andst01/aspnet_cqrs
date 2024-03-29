using SGAS.Application.Interfaces.Base;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;

namespace SGAS.Application.Interfaces
{
    public interface IProdutoApp : IQueryBase<ProdutoViewModel, ProdutoNotification>,
                                   IActionBase<ProdutoViewModel, Produto>
    {
    }
}
