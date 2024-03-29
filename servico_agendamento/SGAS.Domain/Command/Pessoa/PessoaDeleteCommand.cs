using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class PessoaDeleteCommand : PessoaCommand
    {
        //public PessoaDeleteCommand(int id)
        //{
        //    Id = id;
        //}
        public override bool IsValid()
        {
            ValidationResult = new PessoaDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
