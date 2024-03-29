using SGAS.Domain.Validations;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class RegiaoCreateCommand : RegiaoCommand
    {
        //public RegiaoCreateCommand(
        //    string nome, 
        //    string sigla, 
        //    ICollection<UfCommand> uf)
        //{
        //    Nome = nome;
        //    Sigla = sigla;
        //    Uf = uf;
        //}
        public override bool IsValid()
        {
            ValidationResult = new RegiaoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
