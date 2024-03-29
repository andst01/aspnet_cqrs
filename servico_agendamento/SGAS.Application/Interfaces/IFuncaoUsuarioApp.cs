using FluentValidation.Results;
using SGAS.Application.Interfaces.Base;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;
using System.Threading.Tasks;

namespace SGAS.Application.Interfaces
{
    public interface IFuncaoUsuarioApp : IQueryBase<FuncaoUsuarioViewModel, FuncaoUsuarioNotification>,
                                         IActionBase<FuncaoUsuarioViewModel, FuncaoUsuario>
    {
        Task<ValidationResult> Remove(int roleId, int userId);
    }
}
