using SGAS.Domain.Validations;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class MesoRegiaoCreateCommand : MesoRegiaoCommand
    {
        //public MesoRegiaoCreateCommand(int id, 
        //                               string nome,
        //                               int idEstado,
        //                               UfCommand estado,
        //                               ICollection<MicroRegiaoCommand> microRegiao)
        //{
        //    Id = id;
        //    Nome = nome;
        //    IdEstado = idEstado;
        //    Estado = estado;
        //    MicroRegiao = microRegiao;
        //}
        public override bool IsValid()
        {
            ValidationResult = new MesoRegiaoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
