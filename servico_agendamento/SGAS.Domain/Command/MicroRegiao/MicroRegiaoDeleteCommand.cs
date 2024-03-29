using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class MicroRegiaoDeleteCommand : MicroRegiaoCommand
    {
        //public MicroRegiaoDeleteCommand(int id)
        //{
        //    Id = id;
        //}

        public override bool IsValid()
        {
            ValidationResult = new MicroRegiaoDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
