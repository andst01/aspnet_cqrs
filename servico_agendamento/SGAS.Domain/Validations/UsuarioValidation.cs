using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class UsuarioValidation<T> : AbstractValidator<T> where T : UsuarioCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("AspNetUser.Id"));
        }

        protected void ValidaNome()
        {
            RuleFor(x => x.Nome)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("AspNetUser.Nome"));
        }

        protected void ValidaUserName()
        {
            RuleFor(x => x.Nome)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("AspNetUser.UserName"));
        }

        protected void ValidaSenha()
        {
            RuleFor(x => x.Password)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("AspNetUser.Password"));
        }

        protected void ValidaEmail()
        {
            RuleFor(x => x.Email)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("AspNetUser.Email"));
        }
    }


    public class UsuarioCreateValidation : UsuarioValidation<UsuarioCommand>
    {
        public UsuarioCreateValidation()
        {
            ValidaNome();
            ValidaSenha();
            ValidaEmail();
        }
    }

    public class UsuarioUpdateValidation : UsuarioValidation<UsuarioCommand>
    {
        public UsuarioUpdateValidation()
        {
            ValidaId();
            ValidaNome();
            ValidaSenha();
            ValidaEmail();
        }
    }

    public class UsuarioDeleteValidation : UsuarioValidation<UsuarioCommand>
    {
        public UsuarioDeleteValidation()
        {
            ValidaId();
        }
    }
}
