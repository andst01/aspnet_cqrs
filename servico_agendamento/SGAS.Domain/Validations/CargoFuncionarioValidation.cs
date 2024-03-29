using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;
using System;

namespace SGAS.Domain.Validations
{
    public abstract class CargoFuncionarioValidation<T> : AbstractValidator<T> where T : CargoFuncionarioCommand
    {
        protected void ValidaIdFuncionario()
        {
            RuleFor(x => x.IdFuncionario)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("CargoFuncionario.IdFuncionario"));
        }

        protected void ValidaIdCargo()
        {
            RuleFor(x => x.IdFuncionario)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("CargoFuncionario.IdCargo"));
        }

        protected void ValidaDataInicio()
        {
            RuleFor(x => x.DataInicio)
                .Equal(new DateTime())
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("CargoFuncionario.DataInicio"));
        }
    }

    public class CargoFuncionarioCreateValidation : CargoFuncionarioValidation<CargoFuncionarioCommand>
    {
        public CargoFuncionarioCreateValidation()
        {
            ValidaIdFuncionario();
            ValidaIdCargo();
            ValidaDataInicio();
        }
    }

    public class CargoFuncionarioUpdateValidation : CargoFuncionarioValidation<CargoFuncionarioCommand>
    {
        public CargoFuncionarioUpdateValidation()
        {
            ValidaIdFuncionario();
            ValidaIdCargo();
            ValidaDataInicio();
        }
    }

    public class CargoFuncionarioDeleteValidation : CargoFuncionarioValidation<CargoFuncionarioCommand>
    {
        public CargoFuncionarioDeleteValidation()
        {
            ValidaIdFuncionario();
            ValidaIdCargo();
        }
    }
}
