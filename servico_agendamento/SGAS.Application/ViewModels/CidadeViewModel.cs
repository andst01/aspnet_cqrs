using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Application.ViewModels
{
    public class CidadeViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdMicroRegiao { get; set; }
        public int IdEstado { get; set; }

        public virtual EstadoViewModel Estado { get; set; }

        public virtual MicroRegiaoViewModel MicroRegiao { get; set; }

        public virtual ICollection<CepViewModel> Cep { get; set; }

        public virtual ICollection<EnderecoViewModel> Endereco { get; set; }
    }
}