using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class CidadeValidation<T> : AbstractValidator<T> where T : CidadeCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id).NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cidade.Id"));
        }

        protected void ValidaNome()
        {
            RuleFor(x => x.Nome).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cidade.Nome"));

            RuleFor(x => x.Nome).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaNuloOuVazio.ToFormat("Cidade.Nome"));
                 
        }

        protected void ValidaIdEstado()
        {
            RuleFor(x => x.IdEstado).NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cidade.IdEstado"));
        }
    }

    public class CidadeCreateValidation : CidadeValidation<CidadeCommand>
    {
        public CidadeCreateValidation()
        {
            ValidaId();
            ValidaNome();
            ValidaIdEstado();
        }
    }

    public class CidadeUpdateValidation : CidadeValidation<CidadeCommand>
    {
        public CidadeUpdateValidation()
        {
            ValidaNome();
            ValidaIdEstado();
        }
    }

    public class CidadeDeleteValidation : CidadeValidation<CidadeCommand>
    {
        public CidadeDeleteValidation()
        {
            ValidaId();
        }
    }



}
