using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public  class MicroRegiaoCommand : BaseCommand,
        IRequest<MicroRegiao>, IBaseRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdMesoRegiao { get; set; }
        public virtual MesoRegiaoCommand MesoRegiao { get; set; }
        public virtual ICollection<CidadeCommand> Cidade { get; set; }
    }
}
