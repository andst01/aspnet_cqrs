using SGAS.Domain.Entity;
using System;

namespace SGAS.Application.ViewModels
{
    public class AgendaViewModel
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int IdUnidadeVenda { get; set; }
        public int Presenca { get; set; }
        public int IdMotivo { get; set; }
        public virtual MotivoViewModel Motivo { get; set; }
        public string Observacao { get; set; }
        public UnidadeVendaViewModel UnidadeVenda { get; set; }

        public FuncionarioViewModel Funcionario { get; set; }

        public int IdFuncionario { get; set; }
    }
}