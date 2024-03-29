using FluentValidation.Results;
using SGAS.Application.Interfaces.Base;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGAS.Application.Interfaces
{
    public interface IMotivoApp : IQueryBase<MotivoViewModel, MotivoNotification>,
                                  IActionBase<MotivoViewModel, Motivo>
    {
      
    }
}
