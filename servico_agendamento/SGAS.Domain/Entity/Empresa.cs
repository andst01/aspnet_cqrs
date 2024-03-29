using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Entity
{
    public class Empresa : EntidadeBase
    {

        public int Id { get; set; }
        public virtual ICollection<UnidadeVenda> UnidadeVendas { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

    }
}
