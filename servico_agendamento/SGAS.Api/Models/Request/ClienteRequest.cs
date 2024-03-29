using SGAS.Domain.Entity;
using System.Collections.Generic;
using System;
using SGAS.Application.ViewModels;
using System.Runtime.CompilerServices;

namespace SGAS.Api.Models.Request
{
    public class ClienteRequest
    {
        public int Id { get; set; }

        // public List<Agendamento> Agendamentos { get; set; }

        // public List<Venda> Vendas { get; set; }

        //  public virtual Pessoa Pessoa { get; set; }

        public int IdPessoa { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public ClienteRequest() { }

    }

    public static class ClienteReuqestToViewModel 
    {
        public static ClienteViewModel ToResponse(this ClienteRequest request)
        {
            var viewModel = new ClienteViewModel();

            if(request != null)
            {
                viewModel.Id = request.Id;
                viewModel.IdPessoa = request.IdPessoa;
                viewModel.CPF = request.CPF;
                viewModel.RG = request.RG;
                viewModel.Nome = request.Nome;
                viewModel.DataNascimento = request.DataNascimento;
            }
          

            return viewModel;
        }
    }
}
