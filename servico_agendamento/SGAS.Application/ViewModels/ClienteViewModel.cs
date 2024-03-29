using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Application.ViewModels
{
    public class ClienteViewModel 
    {
        public int Id { get; set; }

        public List<AgendamentoViewModel> Agendamentos { get; set; }

        public List<VendaViewModel> Vendas { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }

        public int IdPessoa { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
