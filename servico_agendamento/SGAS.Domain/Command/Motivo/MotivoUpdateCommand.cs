using FluentValidation.Results;
using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class MotivoUpdateCommand : MotivoCommand
    {
        //public MotivoUpdateCommand(int id, string descricao)
        //{
        //    Id = id;
        //    Descricao = descricao;
        //}
        public override bool IsValid()
        {
            ValidationResult = new MotivoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
