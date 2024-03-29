using SGAS.Domain.Validations;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class RegiaoUpdateCommand : RegiaoCommand
    {
        //public RegiaoUpdateCommand(int id,
        //    string nome,
        //    string sigla,
        //    ICollection<UfCommand> uf)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Sigla = sigla;
        //    Uf = uf;
        //}
        public override bool IsValid()
        {
            ValidationResult = new RegiaoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
