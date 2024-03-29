using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class FuncionarioUpdateCommand : FuncionarioCommand
    {
        //public FuncionarioUpdateCommand(int id,
        //                   int idPessoa,
        //                   PessoaCommand pessoa,
        //                   List<CargoFuncionarioCommand> cargosFuncionario,
        //                   string cpf,
        //                   string rg,
        //                   string nome,
        //                   DateTime dataNascimento)
        //{
        //    Id = id;
        //    IdPessoa = idPessoa;
        //    Pessoa = pessoa;
        //    CargosFuncionario = cargosFuncionario;
        //    CPF = cpf;
        //    RG = rg;
        //    Nome = nome;
        //    DataNascimento = dataNascimento;
        //}

        public override bool IsValid()
        {
            ValidationResult = new FuncionarioUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
