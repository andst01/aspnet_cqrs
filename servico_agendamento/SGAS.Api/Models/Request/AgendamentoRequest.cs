using SGAS.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGAS.Api.Models.Request
{
    public class AgendamentoRequest
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public bool DiaInteiro { get; set; }
        public bool VisitaEmCasa { get; set; }
        public int Status { get; set; }

        public AgendamentoRequest() { }

       

    }

    public static class AgendamentoToRequestFromViewModel
    {
        public static AgendamentoViewModel ToResponse(this AgendamentoRequest request)
        {
            var agendamentoViewModel = new AgendamentoViewModel();

            agendamentoViewModel.Id = request.Id;
            agendamentoViewModel.DataFinal = request.DataFinal;
            agendamentoViewModel.DataInicio = request.DataInicio;
            agendamentoViewModel.DiaInteiro = request.DiaInteiro;
            agendamentoViewModel.Status = request.Status;
            agendamentoViewModel.VisitaEmCasa = request.VisitaEmCasa;


            return agendamentoViewModel;
        }
    }
}
