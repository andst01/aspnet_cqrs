using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Api.Models.Request
{
    public class CargoRequest
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Ativo { get; set; }
        public CargoRequest() { }

        public  CargoFuncionarioRequest CargoFuncionario { get; set; }

    }

    public static class CargoToRequestFromViewModel
    {
        public static CargoViewModel ToResponse(this CargoRequest request)
        {
            var viewModel = new CargoViewModel();

            viewModel.Id = request.Id;
            viewModel.Descricao = request.Descricao;
            viewModel.Ativo = request.Ativo;

            return viewModel;
        }
    }

    public class CargoAdicionarRequest
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Ativo { get; set; }
    }

    public static class CargoAdicionarRequestToViewModel
    { 
        public static CargoViewModel ToResponse(this CargoAdicionarRequest request)
        {
            var viewModel = new CargoViewModel();

            viewModel.Id = request.Id;
            viewModel.Descricao = request.Descricao;
            viewModel.Ativo = request.Ativo;

            return viewModel;
        }
    }

}
