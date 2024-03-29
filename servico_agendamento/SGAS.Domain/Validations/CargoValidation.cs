using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Domain.Validations
{
    public abstract class CargoValidation<T> : AbstractValidator<T> where T : CargoCommand
    {
        protected void ValidaDescricao()
        {
            RuleFor(x => x.Descricao)
                .NotEqual(string.Empty)
                .WithMessage(Mensagens.ValidaDataInicio.ToFormat("Cargo.Descricao"));

        }

        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Cargo.Id"));


        }
    }

    public class CargoCreateValidation : CargoValidation<CargoCommand>
    {
        public CargoCreateValidation()
        {
            ValidaDescricao();
        }
    }

    public class CargoUpdateValidation : CargoValidation<CargoCommand>
    {
        public CargoUpdateValidation()
        {
            ValidaId();
            ValidaDescricao();
        }
    }

    public class CargoDeleteValidation : CargoValidation<CargoCommand>
    {
        public CargoDeleteValidation()
        {
            ValidaId();
        }
    }
}
