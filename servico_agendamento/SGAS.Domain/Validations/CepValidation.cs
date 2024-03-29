using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class CepValidation<T> : AbstractValidator<T> where T : CepCommand
    {

        protected void ValidaId()
        {
            RuleFor(x => x.Id).NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cep.Id"));
        }
        protected void ValidateNumeroCep()
        {
            RuleFor(x => x.NumeroCep).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaNuloOuVazio.ToFormat("Cep.NumeroCep"));
        }

        protected void ValidaLogradouro()
        {
            RuleFor(x => x.Logradouro).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaNuloOuVazio.ToFormat("Cep.Logradouro"));
        }

        protected void ValidaBairro()
        {
            RuleFor(x => x.Bairro).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaNuloOuVazio.ToFormat("Cep.Bairro"));
        }

        protected void ValidaUf()
        {
            RuleFor(x => x.Bairro).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaNuloOuVazio.ToFormat("Cep.Uf"));
        }

        protected void ValidaIdCidade()
        {
            RuleFor(x => x.IdCidade).NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cep.IdCidade"));

        }
    }

    public class CepCreateValidation : CepValidation<CepCommand>
    {
        public CepCreateValidation()
        {
            ValidaId();
            ValidaBairro();
            ValidaIdCidade();
            ValidaLogradouro();
            ValidateNumeroCep();
        }
    }

    public class CepUpdateValidation : CepValidation<CepCommand>
    {
        public CepUpdateValidation()
        {
            ValidaBairro();
            ValidaIdCidade();
            ValidaLogradouro();
            ValidateNumeroCep();
        }
    }

    public class CepDeleteValidation : CepValidation<CepCommand>
    {
        public CepDeleteValidation()
        {
            ValidaId();
        }
    }


}
