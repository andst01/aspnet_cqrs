using SGAS.Domain.Validations;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class CidadeCreateCommand : CidadeCommand
    {
        //public CidadeCreateCommand(int id, 
        //                           string nome, 
        //                           int idMicroRegiao, 
        //                           int idEstado,
        //                           UfCommand estado,
        //                           MicroRegiaoCommand microRegiao,
        //                           IList<CepCommand> cep,
        //                           IList<EnderecoCommand> endereco
        //                           )
        //{
        //    Id = id;
        //    Nome = nome;
        //    IdMicroRegiao = idMicroRegiao;
        //    IdEstado = idEstado;
        //    Estado = estado;
        //    MicroRegiao = microRegiao;
        //    Cep = cep;
        //    Endereco = endereco;
        //}
        public override bool IsValid()
        {
            ValidationResult = new CidadeCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
