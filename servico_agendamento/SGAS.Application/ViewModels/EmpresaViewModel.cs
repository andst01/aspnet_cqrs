using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Application.ViewModels
{
    public class EmpresaViewModel 
    {
        public int Id { get; set; }
        public virtual List<UnidadeVendaViewModel> UnidadeVendas { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }

        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }
    }
}
