using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class MesoRegiaoCommand : BaseCommand,
        IRequest<MesoRegiao>, IBaseRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdEstado { get; set; }
        public virtual EstadoCommand Estado { get; set; }
        public virtual ICollection<MicroRegiaoCommand> MicroRegiao { get; set; }
    }
}
