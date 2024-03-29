using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public  class MotivoCommand : BaseCommand,
        IRequest<Motivo>, IBaseRequest
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual List<AgendaCommand> Agenda { get; set; }
    }
}
