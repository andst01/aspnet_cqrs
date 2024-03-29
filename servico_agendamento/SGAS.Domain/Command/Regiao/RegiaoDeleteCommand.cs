using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class RegiaoDeleteCommand : RegiaoCommand
    {
        //public RegiaoDeleteCommand(int id)
        //{
        //    Id = id;
        //}
        public override bool IsValid()
        {
            ValidationResult = new RegiaoDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
