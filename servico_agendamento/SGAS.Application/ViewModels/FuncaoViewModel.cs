using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Application.ViewModels
{
    public class FuncaoViewModel
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string NormalizedName { get; set; }

        public virtual string ConcurrencyStamp { get; set; }

        public ICollection<FuncaoUsuario> FuncoesUsuarios { get; set; }
    }
}
