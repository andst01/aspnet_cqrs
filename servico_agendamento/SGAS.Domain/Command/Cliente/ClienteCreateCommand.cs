using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class ClienteCreateCommand : ClienteCommand
    {
        //public ClienteCreateCommand(int id, 
        //                            int idPessoa, 
        //                            string cpf, 
        //                            string rg, 
        //                            string nome, 
        //                            DateTime dataNascimento, 
        //                            PessoaCommand pessoa)
        //{
        //    Id = id;
        //    IdPessoa = idPessoa;
        //    CPF = cpf;
        //    RG = rg;
        //    Nome = nome;
        //    DataNascimento = dataNascimento;
        //    Pessoa = pessoa;
        //}

        public override bool IsValid()
        {
            ValidationResult = new ClienteCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
