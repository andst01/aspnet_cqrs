using SGAS.Application.ViewModels;
using System;

namespace SGAS.Api.Models.Request
{
    public class AgendaRequest
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int? IdUnidadeVenda { get; set; }
        public int Presenca { get; set; }
        public int IdMotivo { get; set; }
        //public virtual Motivo Motivo { get; set; }
        public string Observacao { get; set; }

        //public virtual UnidadeVenda UnidadeVenda { get; set; }

        public AgendaRequest() { }

    }

    public static class AgendaToRequestFromViewModel
    {
        public static AgendaViewModel ToResponse(this AgendaRequest request)
        {
            var agendaViewModel = new AgendaViewModel();

            agendaViewModel.Id = request.Id;
            agendaViewModel.DataFim = request.DataFim;
            agendaViewModel.DataInicio = request.DataInicio;
            agendaViewModel.IdUnidadeVenda = request.IdUnidadeVenda ?? 0;
            agendaViewModel.Presenca = request.Presenca;
            agendaViewModel.IdMotivo = request.IdMotivo;


            return agendaViewModel;
        }
    }
}
