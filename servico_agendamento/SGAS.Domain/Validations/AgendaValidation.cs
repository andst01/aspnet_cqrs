using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;
using System;

namespace SGAS.Domain.Validations
{
    public abstract class AgendaValidation<T> 
        : AbstractValidator<T> where T : AgendaCommand
    {

        protected void ValidaDataInicio()
        {
            RuleFor(x => x.DataInicio)
                .NotEqual(new DateTime())
                .WithMessage(Mensagens.ValidaDataInicio.ToFormat("Agenda.DataInicio"));

        }

        protected void ValidaDataFinal()
        {
            RuleFor(x => x.DataFim)
               .NotEqual(new DateTime())
               .WithMessage(Mensagens.ValidaDataFim.ToFormat("Agenda.DataFinal"));

        }

        protected void ValidaUnidadeVenda()
        {
            RuleFor(x => x.IdUnidadeVenda)
             .NotEqual(0)
             .WithMessage(Mensagens.ValidaUnidadeVenda.ToFormat("Agenda.IdUnidadeVenda"));

        }

        protected void ValidaId()
        {
            RuleFor(x => x.Id)
             .NotEqual(0)
             .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Agenda.Id"));

        }

    }

    public class AgendaCreateValidation : AgendaValidation<AgendaCommand>
    {
        public AgendaCreateValidation()
        {
            ValidaDataInicio();
            ValidaDataFinal();
            ValidaUnidadeVenda();
        }
    }

    public class AgendaUpdateValidation : AgendaValidation<AgendaCommand>
    {
        public AgendaUpdateValidation()
        {
            ValidaDataInicio();
            ValidaDataFinal();
            ValidaUnidadeVenda();
        }
    }

    public class AgendaDeleteValidation : AgendaValidation<AgendaCommand>
    {
        public AgendaDeleteValidation()
        {
            ValidaDataInicio();
            ValidaDataFinal();
            ValidaUnidadeVenda();
        }
    }

}
