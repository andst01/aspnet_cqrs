using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class UnidadeVendaDeleteCommand : UnidadeVendaCommand
    {
        //public UnidadeVendaDeleteCommand(int id)
        //{
        //    Id = id;
        //}
        public override bool IsValid()
        {
            ValidationResult = new UnidadeVendaDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
