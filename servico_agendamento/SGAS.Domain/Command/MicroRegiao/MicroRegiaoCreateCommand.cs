using SGAS.Domain.Validations;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class MicroRegiaoCreateCommand : MicroRegiaoCommand
    {
        //public MicroRegiaoCreateCommand(string nome, 
        //                                int idMesoRegiao,
        //                                MesoRegiaoCommand mesoRegiao,
        //                                ICollection<CidadeCommand> cidade
        //                                )
        //{
        //    Nome = nome;
        //    IdMesoRegiao = idMesoRegiao;
        //    MesoRegiao = mesoRegiao;
        //    Cidade = cidade;
        //}
        public override bool IsValid()
        {
            ValidationResult = new MicroRegiaoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
