using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;

namespace SGAS.Api.Models.Request
{
    public class FornecedorRequest
    {
        public int Id { get; set; }
       // public virtual Pessoa Pessoa { get; set; }

        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public FornecedorRequest() { }
        
    }

    public static class FornecedorRequestToViewModel
    {
        public static FornecedorViewModel ToResponse(this FornecedorRequest request)
        {
            var viewModel = new FornecedorViewModel();

            viewModel.Id = request.Id;
            viewModel.IdPessoa = request.IdPessoa;
            viewModel.CNPJ = request.CNPJ;
            viewModel.NomeFantasia = request.NomeFantasia;
            viewModel.RazaoSocial = request.RazaoSocial;

            return viewModel;
        }
    }
}
