using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class MesoRegiaoValidation<T> 
        : AbstractValidator<T> where T : MesoRegiaoCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("MesoRegiao.Id"));
        }

        protected void ValidaIdEstado()
        {
            RuleFor(x => x.IdEstado)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("MesoRegiao.IdEstado"));
        }

        protected void ValidaNome()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("MesoRegiao.Nome"));
        }
    }

    public class MesoRegiaoCreateValidation : MesoRegiaoValidation<MesoRegiaoCommand>
    {
        public MesoRegiaoCreateValidation()
        {
            ValidaIdEstado();
            ValidaNome();          
        }
    }

    public class MesoRegiaoUpdateValidation : MesoRegiaoValidation<MesoRegiaoCommand>
    {
        public MesoRegiaoUpdateValidation()
        {
            ValidaId();
            ValidaIdEstado();
            ValidaNome();

        }
    }

    public class MesoRegiaoDeleteValidation : MesoRegiaoValidation<MesoRegiaoCommand>
    {
        public MesoRegiaoDeleteValidation()
        {
            ValidaId();
        }
    }

}
