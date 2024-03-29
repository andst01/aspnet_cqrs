﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SGAS.Domain.Entity
{
    public class CargoFuncionario : EntidadeBase
    {
        public int Id { get; set; }

        [ForeignKey("CGFN_ID_FUNCIONARIO")]
        public int IdFuncionario { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        [ForeignKey("CGFN_ID_CARGO")]
        public int IdCargo { get; set; }
        public virtual Cargo Cargo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }


    }
}
