using SGAS.Domain.Notifications;
using System;

namespace SGAS.Domain.Entity
{
    public class HistoricoEvento : EventBase
    {
        public HistoricoEvento() { }
        public override int Id { get; set; }
        public int Codigo { get; set; }
        public string NomeTabela { get; set; }
        public int CodigoUsuario { get; set; }
        public DateTime DataCadastro { get; set; }
        public string ValoresChaves { get; set; }
        public string ValoresAntigos { get; set; }
        public string ValoresNovos { get; set; }
        public string TipoOperacao { get; set; }

    }
}
