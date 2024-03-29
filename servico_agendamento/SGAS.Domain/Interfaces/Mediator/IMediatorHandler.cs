using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SGAS.Domain.Command;
using SGAS.Domain.Notifications;
using System.Threading.Tasks;

namespace SGAS.Domain.Interfaces.Mediator
{
    public interface IMediatorHandler
    {
        Task<bool?> PublishEvent<T>(T @event) where T : EventBase;
        Task<ValidationResult> SendCommand<T>(T command) where T : BaseCommand;
        Task<T> SendCommand<T>(IRequest<T> command) where T : class;
        Task PublishEvent();


    }
}
