using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public class FuncaoUsuarioValidation<T> : AbstractValidator<T> where T : FuncaoUsuarioCommand
    {
        protected void ValidaUserId()
        {
            RuleFor(x => x.UserId)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("AspNetUserRoles.UserId"));
        }

        protected void ValidaRoleId()
        {
            RuleFor(x => x.RoleId)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("AspNetUserRoles.RoleId"));
        }
    }

    public class FuncaoUsuarioCreateValidation : FuncaoUsuarioValidation<FuncaoUsuarioCommand>
    {
        public FuncaoUsuarioCreateValidation()
        {
            ValidaUserId();
            ValidaRoleId();

        }
    }

    public class FuncaoUsuarioUpdateValidation : FuncaoUsuarioValidation<FuncaoUsuarioCommand>
    {
        public FuncaoUsuarioUpdateValidation()
        {
            ValidaUserId();
            ValidaRoleId();
        }
    }

    public class AspNetUserRolesDeleteValidation : FuncaoUsuarioValidation<FuncaoUsuarioCommand>
    {
        public AspNetUserRolesDeleteValidation()
        {
            ValidaUserId();
            ValidaRoleId();
        }
    }

}
