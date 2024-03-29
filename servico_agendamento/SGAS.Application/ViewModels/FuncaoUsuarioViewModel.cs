using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Application.ViewModels
{
    public class FuncaoUsuarioViewModel
    {
        public  int UserId { get; set; }

        public  int RoleId { get; set; }

        public FuncaoViewModel Role { get; set; }

        public UsuarioViewModel User { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime? DataFim { get; set; }
    }
}
