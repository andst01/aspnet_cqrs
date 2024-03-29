﻿using SGAS.Domain.Interfaces;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using SGAS.Infra.RepositoryMongo.Base;

namespace SGAS.Infra.RepositoryQuery
{
    public class VendaQueryRepository : RepositoryQueryBase<VendaNotification>, IVendaQueryRepository
    {
        public VendaQueryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
