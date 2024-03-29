using MediatR;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Command
{
    public  class CategoriaCommand : BaseCommand,
        IRequest<Categoria>, IBaseRequest
    {

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<ProdutoCommand> Produto { get; set; }


    }
}
