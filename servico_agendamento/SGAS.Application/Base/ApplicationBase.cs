using FluentValidation.Results;
using SGAS.Application.Interfaces;
using SGAS.Application.Interfaces.Base;
using SGAS.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Application.Base
{
    public class ApplicationBase<T> : IApplicationBase<T> where T : class
    {
        public virtual async Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> Register(object request)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<ValidationResult> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> Update(T request)
        {
            throw new NotImplementedException();
        }
    }
}
