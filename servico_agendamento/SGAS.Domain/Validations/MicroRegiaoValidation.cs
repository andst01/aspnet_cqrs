using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public class MicroRegiaoValidation<T>
        : AbstractValidator<T> where T : MicroRegiaoCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("MicroRegiao.Id"));
        }

        protected void ValidaIdMesoRegiao()
        {
            RuleFor(x => x.IdMesoRegiao)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("MicroRegiao.IdMesoRegiao"));
        }

        protected void ValidaNome()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("MicroRegiao.Nome"));
        }
    }

    public class MicroRegiaoCreateValidation : MicroRegiaoValidation<MicroRegiaoCommand>
    {
        public MicroRegiaoCreateValidation()
        {
            ValidaNome();
            ValidaIdMesoRegiao();
        }
    }

    public class MicroRegiaoUpdateValidation : MicroRegiaoValidation<MicroRegiaoCommand>
    {
        public MicroRegiaoUpdateValidation()
        {
            ValidaId();
            ValidaNome();
            ValidaIdMesoRegiao();
        }
    }

    public class MicroRegiaoDeleteValidation : MicroRegiaoValidation<MicroRegiaoCommand>
    {
        public MicroRegiaoDeleteValidation()
        {
            ValidaId();
        }
    }

}
