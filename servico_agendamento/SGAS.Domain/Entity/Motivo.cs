using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Entity
{
    public class Motivo : EntidadeBase
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual List<Agenda> Agenda { get; set; }
    }
}
