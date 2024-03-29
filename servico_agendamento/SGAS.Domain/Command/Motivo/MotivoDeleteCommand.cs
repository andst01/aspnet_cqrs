using FluentValidation.Results;
using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class MotivoDeleteCommand : MotivoCommand
    {
        //public MotivoDeleteCommand(int id)
        //{
        //    Id = id;
        //}
        
        public override bool IsValid()
        {
            ValidationResult = new MotivoDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
