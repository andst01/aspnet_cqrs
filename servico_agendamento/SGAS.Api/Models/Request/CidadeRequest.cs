using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Api.Models.Request
{
    public class CidadeRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdMicroRegiao { get; set; }
        public int IdEstado { get; set; }
        public virtual EstadoRequest Estado { get; set; }
        //public virtual MicroRegiao MicroRegiao { get; set; }
        //public virtual ICollection<Cep> Cep { get; set; }
        //public virtual ICollection<Endereco> Endereco { get; set; }

        public CidadeRequest()
        {

        }
    }

    public static class CidadeRequestToViewModel
    { 
        public static CidadeViewModel ToResponse(this CidadeRequest request)
        {
            var viewModel = new CidadeViewModel();

            if(request != null)
            {
                viewModel.Id = request.Id;
                viewModel.Nome = request.Nome;
                viewModel.IdMicroRegiao = request.IdMicroRegiao;
                viewModel.IdEstado = request.IdEstado;
                viewModel.Estado = request.Estado.ToResponse();
            }
     
            return viewModel;
        }
    }

}
