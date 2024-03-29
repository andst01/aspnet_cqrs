using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class FuncionarioValidation<T> : AbstractValidator<T> where T : FuncionarioCommand
    {

        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Funcionario.Id"));
        }


        protected void ValidaIdPessoa()
        {
            RuleFor(x => x.IdPessoa)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Funcionario.IdPessoa"));
        }

        protected void ValidaCPF()
        {
            RuleFor(x => x.CPF)
                .NotEmpty()
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Funcionario.CPF"));
        }

        protected void ValidaRG()
        {
            RuleFor(x => x.RG)
                .NotEmpty()
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Funcionario.RG"));
        }


        protected void ValidaNome()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Funcionario.Nome"));
        }


    }

    public class FuncionarioCreateValidation : FuncionarioValidation<FuncionarioCommand>
    {
        public FuncionarioCreateValidation()
        {
           // ValidaIdPessoa();
            ValidaNome();
            ValidaCPF();
            ValidaRG();

        }
    }

    public class FuncionarioUpdateValidation : FuncionarioValidation<FuncionarioCommand>
    {
        public FuncionarioUpdateValidation()
        {
            ValidaId();
            ValidaIdPessoa();
            ValidaNome();
            ValidaCPF();
            ValidaRG();

        }
    }

    public class FuncionarioDeleteValidation : FuncionarioValidation<FuncionarioCommand>
    {
        public FuncionarioDeleteValidation()
        {
            ValidaId();

        }
    }
}
