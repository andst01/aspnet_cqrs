using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;
using System;

namespace SGAS.Domain.Validations
{

    public abstract class AgendamentoValidation<T> : AbstractValidator<T> where T : AgendamentoCommand
    {
        protected void ValidaDataInicio()
        {
            RuleFor(x => x.DataInicio)
                .NotEqual(new DateTime())
                .WithMessage(Mensagens.ValidaDataInicio.ToFormat("Agendamento.DataInicio"));

        }

        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Agendamento.Id"));


        }

        //public AgendamentoValidation()
        //{
        //    RuleFor(x => x.DataInicio)
        //        .NotEqual(new DateTime())
        //        .WithMessage(Mensagens.ValidaDataInicio.ToFormat("Agendamento.DataInicio"));

        //}
    }

    public class AgendamentoCreateValidation : AgendamentoValidation<AgendamentoCommand>
    {
        public AgendamentoCreateValidation()
        {
            ValidaDataInicio();
        }
    }

    public class AgendamentoUpdateValidation : AgendamentoValidation<AgendamentoCommand>
    {
        public AgendamentoUpdateValidation()
        {
            ValidaId();
            ValidaDataInicio();
        }
    }

    public class AgendamentoDeleteValidation : AgendamentoValidation<AgendamentoCommand>
    {
        public AgendamentoDeleteValidation()
        {
            ValidaId();
        }
    }
}
