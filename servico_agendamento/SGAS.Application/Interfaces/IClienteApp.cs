using SGAS.Application.Interfaces.Base;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Application.Interfaces
{
    public interface IClienteApp : IQueryBase<ClienteViewModel, ClienteNotification>,
                                   IActionBase<ClienteViewModel, Cliente>
    {
    }
}
