using MediatR;
using SGAS.Domain.Entity;

namespace SGAS.Domain.Command
{
    public class EnderecoCommand : BaseCommand, IRequest<Endereco>, IBaseRequest
    {

        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string TipoNumero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }

        public int IdCidade { get; set; }

        public int? IdCliente { get; set; }

        public CidadeCommand Cidade { get; set; }
        //public virtual ClienteCommand Cliente { get; set; }

        public virtual PessoaCommand Pessoa { get; set; }

        public int IdPessoa { get; set; }
    }

    public static class EnderecoCommandToAction
    {
        public static EnderecoCreateCommand ToCreate(this EnderecoCommand command)
        {
            var action = new EnderecoCreateCommand();

            if (command == null)
                return null;

            action.Id = command.Id;
            action.Cep = command.Cep;
            action.Numero = command.Numero;
            action.TipoNumero = command.TipoNumero;
            action.Logradouro = command.Logradouro;
            action.Bairro = command.Bairro;
            action.Descricao = command.Descricao;
            action.Complemento = command.Complemento;
            action.IdCidade = command.IdCidade;
            action.IdPessoa = command.IdPessoa;
            

            return action;
        }

        public static EnderecoUpdateCommand ToUpdate(this EnderecoCommand command)
        {
            var action = new EnderecoUpdateCommand();

            if (command == null)
                return null;

            action.Id = command.Id;
            action.Cep = command.Cep;
            action.Numero = command.Numero;
            action.TipoNumero = command.TipoNumero;
            action.Logradouro = command.Logradouro;
            action.Bairro = command.Bairro;
            action.Descricao = command.Descricao;
            action.Complemento = command.Complemento;
            action.IdCidade = command.IdCidade;
            action.IdPessoa = command.IdPessoa;


            return action;
        }
    }
}
