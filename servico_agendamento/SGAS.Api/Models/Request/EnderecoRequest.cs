using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;

namespace SGAS.Api.Models.Request
{
    public class EnderecoRequest
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }

        public int IdCidade { get; set; }

        public virtual CidadeRequest Cidade { get; set; }

        public virtual PessoaRequest Pessoa { get; set; }

        public int IdPessoa { get; set; }

        //public EnderecoRequest()
        //{

        //}
    }

    public static class EnderecoRequestToViewModel
    {
        public static EnderecoViewModel ToResponse(this EnderecoRequest request)
        {
            var viewModel = new EnderecoViewModel();

            if(request != null)
            {
                viewModel.Id = request.Id;
                viewModel.Cep = request.Cep;
                viewModel.Numero = request.Numero;
                viewModel.Bairro = request.Bairro;
                viewModel.Complemento = request.Complemento;
                viewModel.Logradouro = request.Logradouro;
                viewModel.IdPessoa = request.IdPessoa;
                viewModel.Pessoa = request.Pessoa.ToResponse();
                viewModel.IdCidade = request.IdCidade;
                viewModel.Cidade = request.Cidade.ToResponse();
            }
  

            return viewModel;
        }
    }
}
