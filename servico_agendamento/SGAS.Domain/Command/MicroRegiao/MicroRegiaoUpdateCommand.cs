using SGAS.Domain.Validations;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class MicroRegiaoUpdateCommand : MicroRegiaoCommand
    {
        //public MicroRegiaoUpdateCommand(int id,
        //                                 string nome,
        //                                 int idMesoRegiao,
        //                                 MesoRegiaoCommand mesoRegiao,
        //                                 ICollection<CidadeCommand> cidade
        //                                 )
        //{
        //    Id = id;
        //    Nome = nome;
        //    IdMesoRegiao = idMesoRegiao;
        //    MesoRegiao = mesoRegiao;
        //    Cidade = cidade;
        //}
        public override bool IsValid()
        {
            ValidationResult = new MicroRegiaoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
