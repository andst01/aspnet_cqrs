using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class CategoriaValidation<T> : AbstractValidator<T> where T : CategoriaCommand
    {
        protected void ValidaId()
        {
            RuleFor(c => c.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Categoria.Id"));
        }

        protected void ValidaDescricao()
        {
            RuleFor(c => c.Descricao)
                .Empty()
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Categoria.Descricao"));
        }
    }

    public class CategoriaCreateValidation : CategoriaValidation<CategoriaCommand>
    {
        public CategoriaCreateValidation()
        {            
            ValidaDescricao();
        }
    }

    public class CategoriaUpdateValidation : CategoriaValidation<CategoriaCommand>
    {
        public CategoriaUpdateValidation()
        {
            ValidaId();
            ValidaDescricao();
        }
    }


    public class CategoriaDeleteValidation : CategoriaValidation<CategoriaCommand>
    {
        public CategoriaDeleteValidation()
        {
            ValidaId();
        }
    }
}
