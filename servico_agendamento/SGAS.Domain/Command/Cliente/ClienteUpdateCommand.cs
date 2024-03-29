using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class ClienteUpdateCommand : ClienteCommand
    {
        //public ClienteUpdateCommand(int id, int idPessoa, string cpf, string rg, string nome, DateTime dataNascimento)
        //{
        //    Id = id;
        //    IdPessoa = idPessoa;
        //    CPF = cpf;
        //    RG = rg;
        //    Nome = nome;
        //    DataNascimento = dataNascimento;
        //}

        public override bool IsValid()
        {
            ValidationResult = new ClienteCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
