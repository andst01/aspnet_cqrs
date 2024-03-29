using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;
using System;

namespace SGAS.Domain.Validations
{
    public abstract class ClienteValidation<T> : AbstractValidator<T> where T : ClienteCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cliente.Id"));
        }

        protected void ValidaIdPessoa()
        {
            RuleFor(x => x.IdPessoa)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cliente.IdPessoa"));
        }

        protected void ValidaCPF()
        {
            RuleFor(x => x.CPF)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cliente.CPF"));
        }

        protected void ValidaRG()
        {
            RuleFor(x => x.RG)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cliente.RG"));
        }

        protected void ValidaNome()
        {
            RuleFor(x => x.RG)
                .Equal(string.Empty)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cliente.Nome"));
        }

        protected void ValidaDataNascimento()
        {
            RuleFor(x => x.DataNascimento)
                .Equal(new DateTime())
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cliente.DataNascimento"));
        }


    }

    public class ClienteCreateValidation : ClienteValidation<ClienteCommand>
    {
        public ClienteCreateValidation()
        {
            ValidaIdPessoa();
            ValidaCPF();
            ValidaRG();
            ValidaNome();

        }
    }

    public class ClienteUpdateValidation : ClienteValidation<ClienteCommand>
    {
        public ClienteUpdateValidation()
        {
            ValidaId();
            ValidaIdPessoa();
            ValidaCPF();
            ValidaRG();
            ValidaNome();
        }
    }

    public class ClienteDeleteValidation : ClienteValidation<ClienteCommand>
    {
        public ClienteDeleteValidation()
        {
            ValidaId();
        }
    }
}
