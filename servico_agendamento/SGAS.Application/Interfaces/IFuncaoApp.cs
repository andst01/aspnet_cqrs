using SGAS.Application.Interfaces.Base;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Application.Interfaces
{
    public interface IFuncaoApp :  IQueryBase<FuncaoViewModel, FuncaoNotification>,
                                   IActionBase<FuncaoViewModel, Funcao>
    {
    }
}
