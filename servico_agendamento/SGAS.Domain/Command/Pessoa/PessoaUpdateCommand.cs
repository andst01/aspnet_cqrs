using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class PessoaUpdateCommand : PessoaCommand
    {
        //public PessoaUpdateCommand(int id, 
        //                           int idUsuario, 
        //                           string telefone, 
        //                           string celular, 
        //                           string email, 
        //                           DateTime dataCadastro, 
        //                           DateTime dataAlteracao, 
        //                           string observacao)
        //{
        //    Id = id;
        //    IdUsuario = idUsuario;
        //    Telefone = telefone;
        //    Celular = celular;
        //    Email = email;
        //    DataCadastro = dataCadastro;
        //    DataAlteracao = dataAlteracao;
        //    Observacao = observacao;
        //}
        public override bool IsValid()
        {
            ValidationResult = new PessoaUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
