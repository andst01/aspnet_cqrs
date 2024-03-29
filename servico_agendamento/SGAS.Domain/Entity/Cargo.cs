using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Entity
{
    public class Cargo : EntidadeBase
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public int Ativo { get; set; }

        public virtual ICollection<CargoFuncionario> CargosFuncionario { get; set; }
    }
}
