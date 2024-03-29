using MediatR;
using SGAS.Domain.Entity;
using System;

namespace SGAS.Domain.Command
{
    public class AgendaCommand : BaseCommand, IRequest<Agenda>, IBaseRequest
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int IdUnidadeVenda { get; set; }
        public int Presenca { get; set; }
        public int IdMotivo { get; set; }
        public virtual MotivoCommand Motivo { get; set; }
        public string Observacao { get; set; }
        public UnidadeVendaCommand UnidadeVenda { get; set; }

        public FuncionarioCommand Funcionario { get; set; }

        public int IdFuncionario { get; set; }

    }
}
