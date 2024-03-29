using SGAS.Application.ViewModels;

namespace SGAS.Api.Models.Request
{
    public class EmpresaRequest
    {
        public int Id { get; set; }
       // public virtual List<UnidadeVenda> UnidadeVendas { get; set; }

       // public virtual Pessoa Pessoa { get; set; }

        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public EmpresaRequest() { }
       
    }

    public static class EmpresaRequestToViewModel
    {
        public static EmpresaViewModel ToResponse(this EmpresaRequest request)
        {
            var viewModel = new EmpresaViewModel();

            if(request != null)
            {
                viewModel.Id = request.Id;
                viewModel.IdPessoa = request.IdPessoa;
                viewModel.NomeFantasia = request.NomeFantasia;
                viewModel.CNPJ = request.CNPJ;
                viewModel.RazaoSocial = request.RazaoSocial;
            }
        

            return viewModel;
        }
    }
}
