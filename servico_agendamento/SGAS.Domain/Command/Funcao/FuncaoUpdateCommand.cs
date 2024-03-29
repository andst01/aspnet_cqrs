using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class FuncaoUpdateCommand : FuncaoCommand
    {
        public FuncaoUpdateCommand(int id, string name, string normalizedName, string concurrencyStamp)
        {
            Id = id;
            Name = name;
            NormalizedName = normalizedName;
            ConcurrencyStamp = concurrencyStamp;
        }

        public override bool IsValid()
        {
            ValidationResult = new FuncaoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
