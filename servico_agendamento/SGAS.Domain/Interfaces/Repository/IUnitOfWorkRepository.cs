using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Domain.Interfaces.Repository
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        

        void Salvar();

        Task SalvarAsync();

       
    }
}
