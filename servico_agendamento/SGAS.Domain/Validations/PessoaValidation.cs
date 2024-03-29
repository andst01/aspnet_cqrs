using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class PessoaValidation<T> : AbstractValidator<T> where T : PessoaCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Pessoa.Id"));
        }

        protected void ValidaIdUsuario()
        {
            RuleFor(x => x.IdUsuario)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Pessoa.IdUsuario"));
        }

        protected void ValidaCelular()
        {
            RuleFor(x => x.Celular)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Pessoa.Celular"));
        }

        protected void ValidaEmail()
        {
            RuleFor(x => x.Email)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Pessoa.Email"));
        }
    }

    public class PessoaCreateValidation : PessoaValidation<PessoaCommand>
    {
        public PessoaCreateValidation()
        {
            //ValidaIdUsuario();
            //ValidaCelular();
            //ValidaEmail();

        }
    }

    public class PessoaUpdateValidation : PessoaValidation<PessoaCommand>
    {
        public PessoaUpdateValidation()
        {
            ValidaId();
            ValidaIdUsuario();
            ValidaCelular();
            ValidaEmail();
        }
    }

    public class PessoaDeleteValidation : PessoaValidation<PessoaCommand>
    {
        public PessoaDeleteValidation()
        {
            ValidaId();
        }
    }
}
