using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Application.Interfaces.Base
{
    public interface IQueryBase<in TRequest, TResponse>
    {
        Task<IEnumerable<TResponse>> GetAll();
        Task<TResponse> GetById(int id);
    }
}
