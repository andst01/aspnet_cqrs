using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public class RegiaoValidation<T>
        : AbstractValidator<T> where T : RegiaoCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Regiao.Id"));
        }

        protected void ValidaSigla()
        {
            RuleFor(x => x.Sigla)
                .NotEmpty()
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Regiao.Sigla"));
        }

        protected void ValidaNome()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Regiao.Nome"));
        }
    }

    public class RegiaoCreateValidation : RegiaoValidation<RegiaoCommand>
    {
        public RegiaoCreateValidation()
        {
            ValidaNome();
            ValidaSigla();
        }
    }

    public class RegiaoUpdateValidation : RegiaoValidation<RegiaoCommand>
    {
        public RegiaoUpdateValidation()
        {
            ValidaId();
            ValidaNome();
            ValidaSigla();
        }
    }

    public class RegiaoDeleteValidation : RegiaoValidation<RegiaoCommand>
    {
        public RegiaoDeleteValidation()
        {
            ValidaId();
        }
    }
}
