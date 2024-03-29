using MediatR;
using SGAS.Domain.Entity;
using System;

namespace SGAS.Domain.Command
{
    public class PessoaCommand : BaseCommand, IRequest<Pessoa>, IBaseRequest
    {

        public int Id { get; set; }
        public bool EhEstrangeiro { get; set; }

        public string Observacao { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public virtual EnderecoCommand Endereco { get; set; }

        public int IdUsuario { get; set; }

        public virtual UsuarioCommand Usuario { get; set; }

        public virtual FuncionarioCommand Funcionario { get; set; }

        public virtual ClienteCommand Cliente { get; set; }

        public virtual EmpresaCommand Empresa { get; set; }

        public virtual FornecedorCommand Fornecedor { get; set; }

        public virtual UnidadeVendaCommand UnidadeVenda { get; set; }
    }

    public static class PessoaCommandToAction
    {
        public static PessoaCreateCommand ToCreate(this PessoaCommand command)
        {
            var actionCommand = new PessoaCreateCommand();

            if (command == null)
                return null;

            actionCommand.Id = command.Id;
            actionCommand.IdUsuario = command.IdUsuario;
            actionCommand.Celular = command.Celular;
            actionCommand.EhEstrangeiro = command.EhEstrangeiro;
            actionCommand.Observacao = command.Observacao;
            actionCommand.DataCadastro = command.DataCadastro;
            actionCommand.Telefone = command.Telefone;
            actionCommand.Email = command.Email;
            actionCommand.DataAlteracao = command.DataAlteracao;
            actionCommand.Usuario = command.Usuario.ToCreate();
            actionCommand.Funcionario = command.Funcionario;
            actionCommand.Cliente = command.Cliente;
            actionCommand.Empresa = command.Empresa;
            actionCommand.Fornecedor = command.Fornecedor;
            actionCommand.UnidadeVenda = command.UnidadeVenda;
            actionCommand.Endereco = command.Endereco;

            return actionCommand;
        }

        public static PessoaUpdateCommand ToUpdate(this PessoaCommand command)
        {
            var actionCommand = new PessoaUpdateCommand();

            if (command == null)
                return null;

            actionCommand.Id = command.Id;
            actionCommand.IdUsuario = command.IdUsuario;
            actionCommand.Celular = command.Celular;
            actionCommand.EhEstrangeiro = command.EhEstrangeiro;
            actionCommand.Observacao = command.Observacao;
            actionCommand.DataCadastro = command.DataCadastro;
            actionCommand.Telefone = command.Telefone;
            actionCommand.Email = command.Email;
            actionCommand.DataAlteracao = command.DataAlteracao;
            actionCommand.Usuario = command.Usuario.ToCreate();
            actionCommand.Funcionario = command.Funcionario;
            actionCommand.Cliente = command.Cliente;
            actionCommand.Empresa = command.Empresa;
            actionCommand.Fornecedor = command.Fornecedor;
            actionCommand.UnidadeVenda = command.UnidadeVenda;
            actionCommand.Endereco = command.Endereco;

            return actionCommand;
        }
    }
}
