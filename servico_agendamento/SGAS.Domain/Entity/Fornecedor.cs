using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SGAS.Domain.Entity
{
    public class Fornecedor : EntidadeBase
    {
        public int Id { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }


    }
}
