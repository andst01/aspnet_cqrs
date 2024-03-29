using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using SGAS.Application.ViewModels;

namespace SGAS.Api.Models.Request
{
    public class ProdutoRequest
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Preco { get; set; }
        public bool? Ativo { get; set; }
        public int IdCategoria { get; set; }

        public ProdutoRequest() { }
       

      //  public virtual Categoria Categoria { get; set; }

     //   public virtual ICollection<ItemVenda> ItemVendas { get; set; }
    }

    public static class ProdutoRequestToViewModel
    {
        public static ProdutoViewModel ToResponse(this ProdutoRequest request)
        {
            var viewModel = new ProdutoViewModel();

            viewModel.Id = request.Id;
            viewModel.Descricao = request.Descricao;
            viewModel.DataCadastro = request.DataCadastro;
            viewModel.DataAtualizacao = request.DataAtualizacao;
            viewModel.Preco = request.Preco;
            viewModel.Ativo = request.Ativo;
            viewModel.IdCategoria = request.IdCategoria;
            
            return viewModel;
        }
    }
}
