using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAS.Api.Models.Request
{
    public class VendaRequest
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Desconto { get; set; }
        public int IdCliente { get; set; }
        // public virtual Cliente Cliente { get; set; }
        public int? IdFuncionario { get; set; }
       //  public virtual Funcionario Funcionario { get; set; }
        public int? IdUnidadeVenda { get; set; }
        //  public virtual UnidadeVenda UnidadeVenda { get; set; }
        // public virtual ICollection<ItemVenda> ItemVenda { get; set; }

        public VendaRequest() { }
        
    }

    public static class VendaRequestToViewModel
    {
        public static VendaViewModel ToResponse(this VendaRequest request)
        {
            var viewModel = new VendaViewModel();

            viewModel.Id = request.Id;
            viewModel.Valor = request.Valor;
            viewModel.Desconto = request.Desconto;
            viewModel.IdCliente = request.IdCliente;
            viewModel.IdFuncionario = request.IdFuncionario;
            viewModel.IdUnidadeVenda = request.IdUnidadeVenda;
            viewModel.Desconto = request.Desconto;
           
            return viewModel;
        }
    }
}
