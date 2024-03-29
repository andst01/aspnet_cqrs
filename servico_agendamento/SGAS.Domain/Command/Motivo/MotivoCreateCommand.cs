using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class MotivoCreateCommand : MotivoCommand
    {
        //public MotivoCreateCommand(int id, string descricao)
        //{
        //    Id = id;
        //    Descricao = descricao;
        //}
        public override bool IsValid()
        {
            ValidationResult = new MotivoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
