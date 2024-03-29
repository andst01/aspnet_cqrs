using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class EnderecoValidation<T> : AbstractValidator<T> where T : EnderecoCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Endereco.Id"));
        }

        protected void ValidaNome()
        {
            RuleFor(x => x.Logradouro).NotEmpty()
                .WithMessage(Mensagens.ValidaNuloOuVazio.ToFormat("Endereco.Logradouro"));
        }

        protected void ValidaNumero()
        {
            RuleFor(x => x.Numero).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaNuloOuVazio.ToFormat("Endereco.Numero"));
        }

        protected void ValidaCep()
        {
            RuleFor(x => x.Cep).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaNuloOuVazio.ToFormat("Endereco.Cep"));
        }

        protected void ValidaBairro()
        {
            RuleFor(x => x.Bairro).NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaNuloOuVazio.ToFormat("Endereco.Bairro"));
        }
    }

    public class EnderecoCreateValidation : EnderecoValidation<EnderecoCommand>
    {
        public EnderecoCreateValidation()
        {
            //ValidaId();
            //ValidaNome();
            //ValidaNumero();
            //ValidaBairro();
            //ValidaCep();
        }
    }

    public class EnderecoUpdateValidation : EnderecoValidation<EnderecoCommand>
    {
        public EnderecoUpdateValidation()
        {
            ValidaNome();
            ValidaNumero();
            ValidaBairro();
            ValidaCep();

        }
    }

    public class EnderecoDeleteValidation : EnderecoValidation<EnderecoCommand>
    {
        public EnderecoDeleteValidation()
        {
            ValidaId();
        }
    }
}
