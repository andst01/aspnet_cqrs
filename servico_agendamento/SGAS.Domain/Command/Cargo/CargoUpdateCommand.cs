using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class CargoUpdateCommand : CargoCommand
    {

        //public CargoUpdateCommand(int id, string descricao, bool ativo)
        //{
        //    Id = id;
        //    Descricao = descricao;
        //    Ativo = ativo;
        //}
        public override bool IsValid()
        {
            ValidationResult = new CargoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
