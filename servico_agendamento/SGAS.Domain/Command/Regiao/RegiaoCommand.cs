using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class RegiaoCommand : BaseCommand, IRequest<Regiao>, IBaseRequest
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<EstadoCommand> Estados { get; set; }
    }
}
