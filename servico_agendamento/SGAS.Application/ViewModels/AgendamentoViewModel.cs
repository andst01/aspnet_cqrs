using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Application.ViewModels
{
    public class AgendamentoViewModel
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public bool DiaInteiro { get; set; }
        public bool VisitaEmCasa { get; set; }
        public int Status { get; set; }

        public virtual FuncionarioViewModel ResponsavelServico { get; set; }

        public int? IdResponsavelServico { get; set; }

        public int? IdAtendente { get; set; }

        public virtual FuncionarioViewModel Atendente { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
        public int IdCliente { get; set; }

        public virtual List<ServicoViewModel> Servico { get; set; }

        public int? IdUnidadeVenda { get; set; }
        public virtual UnidadeVendaViewModel UnidadeVenda { get; set; }
    }
}
