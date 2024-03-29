using MediatR;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public  class AgendamentoCommand : BaseCommand, IRequest<Agendamento>, IBaseRequest
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public bool DiaInteiro { get; set; }
        public bool VisitaEmCasa { get; set; }
        public int Status { get; set; }

        public virtual FuncionarioCommand ResponsavelServico { get; set; }

        public int? IdResponsavelServico { get; set; }

        public int? IdAtendente { get; set; }

        public virtual FuncionarioCommand Atendente { get; set; }

        public virtual ClienteCommand Cliente { get; set; }
        public int IdCliente { get; set; }

        public virtual List<ServicoCommand> Servico { get; set; }

        public int? IdUnidadeVenda { get; set; }
        public virtual UnidadeVendaCommand UnidadeVenda { get; set; }


    }
}
