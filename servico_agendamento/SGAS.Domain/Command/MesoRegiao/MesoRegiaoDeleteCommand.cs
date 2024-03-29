using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class MesoRegiaoDeleteCommand : MesoRegiaoCommand
    {
        //public MesoRegiaoDeleteCommand(int id)
        //{
        //    Id = id;
        //}
        public override bool IsValid()
        {
            ValidationResult = new MesoRegiaoDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
