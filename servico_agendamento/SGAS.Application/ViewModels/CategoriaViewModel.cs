using System.Collections.Generic;

namespace SGAS.Application.ViewModels
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<ProdutoViewModel> Produto { get; set; }

    }
}
