using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class EstadoValidation<T> : AbstractValidator<T> where T : EstadoCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id).NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Uf.Id"));
        }

        protected void ValidaSigla()
        {
            RuleFor(x => x.Sigla).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Uf.Sigla"));
        }

        protected void ValidaNome()
        {
            RuleFor(x => x.Nome).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Uf.Nome"));
        }
    }

    public class EstadoCreateValidation : EstadoValidation<EstadoCommand>
    {
        public EstadoCreateValidation()
        {
            
            ValidaSigla();
            ValidaNome();
        }
    }

    public class EstadoUpdateValidation : EstadoValidation<EstadoCommand>
    {
        public EstadoUpdateValidation()
        {
            ValidaId();
            ValidaSigla();
            ValidaNome();

        }
    }

    public class EstadoDeleteValidation : EstadoValidation<EstadoCommand>
    {
        public EstadoDeleteValidation()
        {
            ValidaId();
        }
    }

}
