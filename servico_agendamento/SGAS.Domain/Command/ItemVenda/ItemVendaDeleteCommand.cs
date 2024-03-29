using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class ItemVendaDeleteCommand : ItemVendaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new ItemVendaDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
