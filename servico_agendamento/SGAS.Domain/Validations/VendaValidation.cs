using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public abstract class VendaValidation<T>
        : AbstractValidator<T> where T : VendaCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Venda.Id"));
        }

        protected void ValidaValor()
        {
            RuleFor(x => x.Valor)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Venda.Valor"));
        }

        protected void ValidaIdUsuario()
        {
            RuleFor(x => x.Valor)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Venda.IdUsuario"));
        }

        protected void ValidaIdCliente()
        {
            RuleFor(x => x.Valor)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Venda.IdCliente"));
        }
    }

    public class VendaCreateValidation : VendaValidation<VendaCommand>
    {
        public VendaCreateValidation()
        {
            ValidaIdCliente();
            ValidaIdUsuario();
            ValidaValor();
        }
    }

    public class VendaUpdateValidation : VendaValidation<VendaCommand>
    {
        public VendaUpdateValidation()
        {
            ValidaId();
            ValidaIdCliente();
            ValidaIdUsuario();
            ValidaValor();
        }
    }

    public class VendaDeleteValidation : VendaValidation<VendaCommand>
    {
        public VendaDeleteValidation()
        {
            ValidaId();
        }
    }

}
