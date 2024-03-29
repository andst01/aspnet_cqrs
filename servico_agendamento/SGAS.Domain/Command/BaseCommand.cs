using FluentValidation.Results;
using SGAS.Domain.Notifications;
using MediatR;
using System;

namespace SGAS.Domain.Command
{
    public class BaseCommand : EventoMensagem, IRequest<ValidationResult>, IBaseRequest
    {
        public Guid Codigo { get; protected set; }
        public DateTime DataCriacao { get; private set; }

        public ValidationResult ValidationResult { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public virtual bool IsValid()
        {
            return false;
        }


    }
}
