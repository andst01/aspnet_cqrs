using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Application.Interfaces.Facade
{
    public interface IDadosIbgeFacade
    {
        Task<bool> InserirCidades();
    }
}
