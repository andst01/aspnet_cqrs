using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using System.Collections.Generic;
using System.Linq;

namespace SGAS.Api.Models.Request
{
    public class UnidadeVendaRequest
    {
        public int Id { get; set; }

        public virtual List<AgendamentoRequest> Agendamentos { get; set; }

        public virtual List<AgendaRequest> Agendas { get; set; }

        public virtual List<VendaRequest> Vendas { get; set; }

        public int IdEmpresa { get; set; }

        public virtual EmpresaRequest Empresa { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public UnidadeVendaRequest() { }
        
    }

    public static class UnidadeVendaRequestToViewModel
    {
        public static UnidadeVendaViewModel ToResponse(this UnidadeVendaRequest request)
        {
            var viewModel = new UnidadeVendaViewModel();

            viewModel.Id = request.Id;
            viewModel.IdEmpresa = request.IdEmpresa;
            viewModel.CNPJ = request.CNPJ;
            viewModel.NomeFantasia = request.NomeFantasia;
            viewModel.RazaoSocial = request.RazaoSocial;
            viewModel.Empresa = request.Empresa.ToResponse();
            viewModel.Vendas = request.Vendas.Select(a => a.ToResponse()).ToList();


            return viewModel;
        }
    }
}
