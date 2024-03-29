using SGAS.Domain.Interfaces.RepositoryMongo.Base;
using SGAS.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Domain.Interfaces.RepositoryQuery
{
    public interface IAgendaQueryRepository : IRepositoryQueryBase<AgendaNotification>
    {
    }
}
