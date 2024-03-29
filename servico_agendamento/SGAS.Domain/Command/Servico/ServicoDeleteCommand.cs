using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class ServicoDeleteCommand : ServicoCommand
    {
        //public ServicoDeleteCommand(int id)
        //{
        //    Id = id;
        //}

        public override bool IsValid()
        {
            ValidationResult = new ServicoDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
