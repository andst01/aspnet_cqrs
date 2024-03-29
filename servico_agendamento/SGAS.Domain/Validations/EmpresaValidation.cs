using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class EmpresaValidation<T> : AbstractValidator<T> where T : EmpresaCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Empresa.Id"));
        }

        protected void ValidaIdPessoa()
        {
            RuleFor(x => x.IdPessoa)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Empresa.IdPessoa"));
        }

        protected void ValidaCNPJ()
        {
            RuleFor(x => x.CNPJ)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Empresa.CNPJ"));
        }

        protected void ValidaRazaoSocial()
        {
            RuleFor(x => x.CNPJ)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Empresa.RazaoSocial"));
        }

        protected void ValidaNomeFantasia()
        {
            RuleFor(x => x.CNPJ)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Empresa.NomeFantasia"));
        }
    }

    public class EmpresaCreateValidation : EmpresaValidation<EmpresaCommand>
    {
        public EmpresaCreateValidation()
        {
            ValidaIdPessoa();
            ValidaCNPJ();
            ValidaRazaoSocial();
            ValidaNomeFantasia();
        }
    }

    public class EmpresaUpdateValidation : EmpresaValidation<EmpresaCommand>
    {
        public EmpresaUpdateValidation()
        {
            ValidaId();
            ValidaIdPessoa();
            ValidaCNPJ();
            ValidaRazaoSocial();
            ValidaNomeFantasia();
        }
    }

    public class EmpresaDeleteValidation : EmpresaValidation<EmpresaCommand>
    {
        public EmpresaDeleteValidation()
        {
            ValidaId();
        }
    }

}
