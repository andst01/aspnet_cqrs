using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Application.Interfaces.Base
{
    public interface IActionBase<in TRequest, TResponse>
    {
        Task<TResponse> Register(TRequest request);
        Task<TResponse> Update(TRequest request);
        Task<ValidationResult> Remove(int id);
    }
}
