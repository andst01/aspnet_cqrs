using System.Collections.Generic;
using System;
using SGAS.Application.ViewModels;
using System.Linq;
using System.Text.Json.Serialization;


namespace SGAS.Api.Models.Request
{
    public class FuncionarioRequest
    {
        
        public int Id { get; set; }
        public int IdPessoa { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PessoaRequest Pessoa { get; set; } = null;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string CPF { get; set; } = null;
        public string RG { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
      
        
    }

    public static class FuncionarioRequestToViewModel
    {
        public static FuncionarioViewModel ToResponse(this FuncionarioRequest request)
        {
            var viewModel = new FuncionarioViewModel();

            if(request != null)
            {
                viewModel.Id = request.Id;
                viewModel.IdPessoa = request.IdPessoa;
                viewModel.CPF = request.CPF;
                viewModel.RG = request.RG;
                viewModel.Nome = request.Nome;
                viewModel.DataNascimento = request.DataNascimento;
                viewModel.Pessoa = request.Pessoa.ToResponse();
            }
    
          //  viewModel.ResponsaveisServico = request.ResponsaveisServico.Select(a => a.ToResponse()).ToList();
         //   viewModel.Atendentes = request.Atendentes.Select(a => a.ToResponse()).ToList();
          //  viewModel.CargosFuncionario = request.CargosFuncionario.Select(a => a.ToResponse()).ToList();

            return viewModel;
        }
    }

}
