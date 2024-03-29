using SGAS.Domain.Entity;
using System.Collections.Generic;
using System;

namespace SGAS.Application.ViewModels
{
    public class FuncionarioViewModel
    {
        public int Id { get; set; }

        public List<CargoFuncionarioViewModel> CargosFuncionario { get; set; }

        public List<AgendamentoViewModel> ResponsaveisServico { get; set; }
        public List<AgendamentoViewModel> Atendentes { get; set; }

        public virtual List<VendaViewModel> Vendas { get; set; }

        public virtual List<AgendaViewModel> Agendas { get; set; }

        public int IdPessoa { get; set; }
        public virtual PessoaViewModel Pessoa { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}