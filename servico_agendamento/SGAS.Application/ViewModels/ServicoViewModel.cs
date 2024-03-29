using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;

namespace SGAS.Application.ViewModels
{
    public class ServicoViewModel
    {
        public int Id { get; set; }
        public int IdAgendamento { get; set; }
        public virtual AgendamentoViewModel Agendamento { get; set; }
        public int IdUsuarioResponsavel { get; set; }
        public int CodigoServico { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioCriacao { get; set; }
        public int QuantidadeParcelas { get; set; }
        public decimal ValorTotal { get; set; }

        public UsuarioViewModel UsuarioCriacao { get; set; }

        public UsuarioViewModel UsuarioResponsavel { get; set; }
    }
}