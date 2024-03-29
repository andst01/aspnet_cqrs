using FluentValidation.Results;
using SGAS.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGAS.Application.Interfaces.Base
{
    public interface IApplicationBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Register(object request);
        Task<T> Update(T request);
        Task<ValidationResult> Remove(int id);
    }
}
