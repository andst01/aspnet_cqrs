using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class AgendamentoDeleteCommand : AgendamentoCommand
    {
       
        public override bool IsValid()
        {
            ValidationResult = new AgendamentoDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
