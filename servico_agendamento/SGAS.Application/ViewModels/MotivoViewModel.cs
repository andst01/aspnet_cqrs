using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Application.ViewModels
{
    public class MotivoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual List<AgendaViewModel> Agenda { get; set; }
    }
}
