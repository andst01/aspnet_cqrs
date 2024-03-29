using SGAS.Application.ViewModels;
using System;

namespace SGAS.Api.Models.Request
{
    public class CargoFuncionarioRequest
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public FuncionarioRequest Funcionario { get; set; }
        public int IdCargo { get; set; }
        public CargoRequest Cargo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        public CargoFuncionarioRequest() { }
        
    }

    public static class CargoRequestToViewModel
    {
        public static CargoFuncionarioViewModel ToResponse(this CargoFuncionarioRequest request)
        {
            var viewModel = new CargoFuncionarioViewModel();

            viewModel.Id = request.Id;
            viewModel.IdFuncionario = request.IdFuncionario;
            viewModel.IdCargo = request.IdCargo;
            viewModel.DataInicio = request.DataInicio;
            viewModel.DataFim = request.DataFim;
            viewModel.Funcionario = request.Funcionario.ToResponse();
            viewModel.Cargo = request.Cargo.ToResponse();

            return viewModel;
        }
    }
}
