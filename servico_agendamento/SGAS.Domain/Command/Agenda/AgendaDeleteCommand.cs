using FluentValidation.Results;
using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class AgendaDeleteCommand : AgendaCommand
    {
        

        public override bool IsValid()
        {
            ValidationResult = new AgendaDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
