using SGAS.Application.ViewModels;
using System;

namespace SGAS.Api.Models.Request
{
    public class ServicoRequest
    {
        public int Id { get; set; }
        public int IdAgendamento { get; set; }
        // public virtual Agendamento Agendamento { get; set; }
        public int IdUsuarioResponsavel { get; set; }
        public int CodigoServico { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioCriacao { get; set; }
        public int QuantidadeParcelas { get; set; }
        public decimal ValorTotal { get; set; }

        // public Usuario UsuarioCriacao { get; set; }

        // public Usuario UsuarioResponsavel { get; set; }

        public ServicoRequest() { }
       
    }

    public static class ServicoRequestToViewModel
    {
        public static ServicoViewModel ToResponse(this ServicoRequest request)
        {
            var viewModel = new ServicoViewModel();

            viewModel.Id = request.Id;
            viewModel.IdAgendamento = request.IdAgendamento;
            viewModel.IdUsuarioCriacao = request.IdUsuarioCriacao;
            viewModel.IdUsuarioResponsavel = request.IdUsuarioResponsavel;
            viewModel.CodigoServico = request.CodigoServico;
            viewModel.DataCadastro = request.DataCadastro;
            viewModel.QuantidadeParcelas = request.QuantidadeParcelas;
            viewModel.ValorTotal = request.ValorTotal;

            return viewModel;
        }
    }
}
