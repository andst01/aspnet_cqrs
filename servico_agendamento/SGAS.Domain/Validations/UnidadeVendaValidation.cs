using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class UnidadeVendaValidation<T> : AbstractValidator<T> where T : UnidadeVendaCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("UnidadeVenda.Id"));
        }

        protected void ValidaIdPessoa()
        {
            RuleFor(x => x.IdPessoa)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("UnidadeVenda.IdPessoa"));
        }

        protected void ValidaIdEmpresaa()
        {
            RuleFor(x => x.IdEmpresa)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("UnidadeVenda.IdEmpresa"));
        }

        protected void ValidaCNPJ()
        {
            RuleFor(x => x.CNPJ)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("UnidadeVenda.CNPJ"));
        }

        protected void ValidaRazaoSocial()
        {
            RuleFor(x => x.CNPJ)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("UnidadeVenda.RazaoSocial"));
        }

        protected void ValidaNomeFantasia()
        {
            RuleFor(x => x.CNPJ)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("UnidadeVenda.NomeFantasia"));
        }
    }

    public class UnidadeVendaCreateValidation : UnidadeVendaValidation<UnidadeVendaCommand>
    {
        public UnidadeVendaCreateValidation()
        {
            ValidaIdPessoa();
            ValidaIdEmpresaa();
            ValidaCNPJ();
            ValidaRazaoSocial();
            ValidaNomeFantasia();

        }
    }

    public class UnidadeVendaUpdateValidation : UnidadeVendaValidation<UnidadeVendaCommand>
    {
        public UnidadeVendaUpdateValidation()
        {
            ValidaId();
            ValidaIdPessoa();
            ValidaIdEmpresaa();
            ValidaCNPJ();
            ValidaRazaoSocial();
            ValidaNomeFantasia();
        }
    }

    public class UnidadeVendaDeleteValidation : UnidadeVendaValidation<UnidadeVendaCommand>
    {
        public UnidadeVendaDeleteValidation()
        {
            ValidaId();
        }
    }
}
