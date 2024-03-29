using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Application.ViewModels
{
    public class CargoFuncionarioViewModel
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public FuncionarioViewModel Funcionario { get; set; }
        public int IdCargo { get; set; }
        public CargoViewModel Cargo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}
