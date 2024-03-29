using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Application.ViewModels
{
    public class HistoricoEventoViewModel
    {
        public string Dados { get;  set; }
        public string Usuario { get;  set; }

        public Guid Codigo { get;  set; }
        public DateTime DataEvento { get;  set; }

        public Guid CodigoMensagem { get;  set; }
        public string TipoMensagem { get;  set; }
    }
}
