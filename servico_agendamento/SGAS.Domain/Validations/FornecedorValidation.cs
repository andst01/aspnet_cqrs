using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class FornecedorValidation<T> : AbstractValidator<T> where T : FornecedorCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Fornecedor.Id"));
        }

        protected void ValidaIdPessoa()
        {
            RuleFor(x => x.IdPessoa)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Fornecedor.IdPessoa"));
        }

        protected void ValidaCNPJ()
        {
            RuleFor(x => x.CNPJ)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Fornecedor.CNPJ"));
        }

        protected void ValidaRazaoSocial()
        {
            RuleFor(x => x.CNPJ)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Fornecedor.RazaoSocial"));
        }

        protected void ValidaNomeFantasia()
        {
            RuleFor(x => x.CNPJ)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Fornecedor.NomeFantasia"));
        }
    }

    public class FornecedorCreateValidation : FornecedorValidation<FornecedorCommand>
    {
        public FornecedorCreateValidation()
        {
            ValidaIdPessoa();
            ValidaCNPJ();
            ValidaRazaoSocial();
            ValidaNomeFantasia();
        }
    }

    public class FornecedorUpdateValidation : FornecedorValidation<FornecedorCommand>
    {
        public FornecedorUpdateValidation()
        {
            ValidaId();
            ValidaIdPessoa();
            ValidaCNPJ();
            ValidaRazaoSocial();
            ValidaNomeFantasia();
        }
    }


    public class FornecedorDeleteValidation : FornecedorValidation<FornecedorCommand>
    {
        public FornecedorDeleteValidation()
        {
            ValidaId();
        }
    }
}
