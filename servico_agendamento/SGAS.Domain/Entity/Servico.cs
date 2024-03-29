using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Entity
{
    public class Servico : EntidadeBase
    {

        public int Id { get; set; }
        public int IdAgendamento { get; set; }
        public virtual Agendamento Agendamento { get; set; }
        public int IdUsuarioResponsavel { get; set; }
        public int CodigoServico { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioCriacao { get; set; }
        public int QuantidadeParcelas { get; set; }
        public decimal ValorTotal { get; set; }

        public Usuario UsuarioCriacao { get; set; }

        public Usuario UsuarioResponsavel { get; set; }


    }
}
