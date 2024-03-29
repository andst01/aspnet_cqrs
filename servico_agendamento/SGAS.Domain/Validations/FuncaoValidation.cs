using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class FuncaoValidation<T> : AbstractValidator<T> where T : FuncaoCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("AspNetRole.Id"));
        }

        protected void ValidaName()
        {
            RuleFor(x => x.Name)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("AspNetRole.Name"));
        }
    }

    public class FuncaoCreateValidation : FuncaoValidation<FuncaoCommand>
    {
        public FuncaoCreateValidation()
        {
            ValidaName();
        }
    }

    public class FuncaoUpdateValidation : FuncaoValidation<FuncaoCommand>
    {
        public FuncaoUpdateValidation()
        {
            ValidaId();
            ValidaName();
        }
    }

    public class FuncaoDeleteValidation : FuncaoValidation<FuncaoCommand>
    {
        public FuncaoDeleteValidation()
        {
            ValidaId();
        }
    }
}
