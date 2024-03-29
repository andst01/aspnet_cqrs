using SGAS.Domain.Interfaces.RepositoryMongo.Base;
using SGAS.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Interfaces.RepositoryQuery
{
    public interface ICategoriaQueryRepository : IRepositoryQueryBase<CategoriaNotification>
    {
    }
}
