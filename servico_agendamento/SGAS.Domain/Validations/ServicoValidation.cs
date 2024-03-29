using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public class ServicoValidation<T> : AbstractValidator<T> where T : ServicoCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Servico.Id"));


        }

        protected void ValidaIdAgendamento()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Servico.IdAgendamento"));


        }

        protected void ValidaIdUserResponsavel()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Servico.IdUsuarioResponsavel"));


        }

        protected void ValidaIdUserCriacao()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Servico.IdUsuarioCriacao"));


        }

       
    }

    public class ServicoCreateValidation : ServicoValidation<ServicoCommand>
    {
        public ServicoCreateValidation()
        {
            ValidaIdAgendamento();
            ValidaIdUserCriacao();
            ValidaIdUserResponsavel();
            
        }
    }

    public class ServicoUpdateValidation : ServicoValidation<ServicoCommand>
    {
        public ServicoUpdateValidation()
        {
            ValidaId();
            ValidaIdAgendamento();
            ValidaIdUserCriacao();
            ValidaIdUserResponsavel();
        }
    }

    public class ServicoDeleteValidation : ServicoValidation<ServicoCommand>
    {
        public ServicoDeleteValidation()
        {
            ValidaId();
        }
    }

}
