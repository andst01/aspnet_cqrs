using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class FuncaoCommand : BaseCommand, IRequest<Funcao>, IBaseRequest
    {

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string NormalizedName { get; set; }

        public virtual string ConcurrencyStamp { get; set; }

        public ICollection<FuncaoUsuarioCommand> FuncoesUsuarios { get; set; }


    }
}
