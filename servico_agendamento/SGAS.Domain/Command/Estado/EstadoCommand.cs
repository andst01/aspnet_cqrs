using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class EstadoCommand : BaseCommand, IRequest<Estado>, IBaseRequest
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public int IdRegiao { get; set; }

        public virtual RegiaoCommand Regiao { get; set; }

        public virtual ICollection<CidadeCommand> Cidade { get; set; }

        public virtual ICollection<MesoRegiaoCommand> MesoRegiao { get; set; }
    }
}
