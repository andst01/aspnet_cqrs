using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public  class CidadeCommand : BaseCommand, IRequest<Cidade>, IBaseRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdMicroRegiao { get; set; }
        public int IdEstado { get; set; }

        public virtual EstadoCommand Estado { get; set; }
        public virtual MicroRegiaoCommand MicroRegiao { get; set; }
        public virtual ICollection<CepCommand> Cep { get; set; }

        public virtual ICollection<EnderecoCommand> Endereco { get; set; }
    }

    public static class CidadeCommandToAction
    {
        public static CidadeCreateCommand ToCreate(this CidadeCommand command)
        {
            var action = new CidadeCreateCommand();

            if (command == null) return null;

            action.Id = command.Id;
            action.Nome = command.Nome;
            action.IdEstado = command.IdEstado;
            action.IdMicroRegiao = command.IdMicroRegiao;


            return action;
        }

        public static CidadeUpdateCommand ToUpdate(this CidadeCommand command)
        {
            var action = new CidadeUpdateCommand();

            if (command == null) return null;

            action.Id = command.Id;
            action.Nome = command.Nome;
            action.IdEstado = command.IdEstado;
            action.IdMicroRegiao = command.IdMicroRegiao;


            return action;
        }
    }
}
