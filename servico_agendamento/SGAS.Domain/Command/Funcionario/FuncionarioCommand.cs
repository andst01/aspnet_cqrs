using MediatR;
using Newtonsoft.Json;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public  class FuncionarioCommand : BaseCommand, 
        IRequest<Funcionario>, IBaseRequest
    {

        public int Id { get; set; }

        [JsonIgnore]
        public  List<CargoFuncionarioCommand>? CargosFuncionario { get; set; } = null;

        [JsonIgnore]
        public  List<AgendamentoCommand>? ResponsaveisServico { get; set; } = null;

        [JsonIgnore]
        public  List<AgendamentoCommand>? Atendentes { get; set; }

        [JsonIgnore]
        public List<AgendaCommand>? Agendas { get; set; }

        [JsonIgnore]
        public  List<VendaCommand>? Vendas { get; set; }

        public int IdPessoa { get; set; }
        public virtual PessoaCommand Pessoa { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
    }

    public static class FuncionarioCommandToActions
    {
        public static FuncionarioCreateCommand ToCreate(this FuncionarioCommand command)
        {
            var actionCommand = new FuncionarioCreateCommand();

            if (command == null)
                return null;

            actionCommand.Id = command.Id;
            actionCommand.IdPessoa = command.IdPessoa;
            actionCommand.CPF = command.CPF;
            actionCommand.RG = command.RG;
            actionCommand.Nome = command.Nome;
            actionCommand.DataNascimento = command.DataNascimento;
            actionCommand.Pessoa = command.Pessoa.ToCreate();

            return actionCommand;
        }

        public static FuncionarioUpdateCommand ToUpdate(this FuncionarioCommand command)
        {
            var actionCommand = new FuncionarioUpdateCommand();

            if (command == null)
                return null;

            actionCommand.Id = command.Id;
            actionCommand.IdPessoa = command.IdPessoa;
            actionCommand.CPF = command.CPF;
            actionCommand.RG = command.RG;
            actionCommand.Nome = command.Nome;
            actionCommand.DataNascimento = command.DataNascimento;
            actionCommand.Pessoa = command.Pessoa.ToUpdate();

            return actionCommand;
        }

        public static FuncionarioDeleteCommand ToDelete(this FuncionarioCommand command)
        {
            var actionCommand = new FuncionarioDeleteCommand();

            if (command == null)
                return null;

            actionCommand.Id = command.Id;
            actionCommand.IdPessoa = command.IdPessoa;
            actionCommand.CPF = command.CPF;
            actionCommand.RG = command.RG;
            actionCommand.Nome = command.Nome;
            actionCommand.DataNascimento = command.DataNascimento;

            return actionCommand;
        }
    }
}
