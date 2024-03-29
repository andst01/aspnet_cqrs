using FluentValidation;
using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class ItemServicoDeleteCommand : ItemServicoCommand
    {
        public ItemServicoDeleteCommand(int id)
        {
            Id = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new ItemServicoDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
