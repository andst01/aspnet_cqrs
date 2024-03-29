using SGAS.Application.ViewModels;

namespace SGAS.Api.Models.Request
{
    public class EstadoRequest
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public int IdRegiao { get; set; }

        public EstadoRequest() { }
       
    }

    public static class EstadoRequestToViewModel
    {
        public static EstadoViewModel ToResponse(this EstadoRequest request)
        {
            var viewModel = new EstadoViewModel();

            viewModel.Id = request.Id;
            viewModel.Nome = request.Nome;
            viewModel.IdRegiao = request.IdRegiao;
            viewModel.Sigla = request.Sigla;

            return viewModel;
        }
    }
}
