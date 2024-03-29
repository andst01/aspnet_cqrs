using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class MotivoValidation<T> : AbstractValidator<T> where T : MotivoCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Motivo.Id"));


        }

        protected void ValidaDescricao()
        {
            RuleFor(x => x.Descricao)
                .NotEqual(string.Empty)
                .NotNull()
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Motivo.Descricao"));
        }


    }

    public class MotivoCreateValidation : MotivoValidation<MotivoCommand>
    {
        public MotivoCreateValidation()
        {
            ValidaId();
            ValidaDescricao();
        }
    }

    public class MotivoUpdateValidation : MotivoValidation<MotivoCommand>
    {
        public MotivoUpdateValidation()
        {
            ValidaId();
            ValidaDescricao();
        }
    }

    public class MotivoDeleteValidation : MotivoValidation<MotivoCommand>
    {
        public MotivoDeleteValidation()
        {
            ValidaId();
        }
    }
}
