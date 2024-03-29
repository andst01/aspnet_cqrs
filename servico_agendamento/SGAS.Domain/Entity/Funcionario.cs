using MongoDB.Driver.Core.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SGAS.Domain.Entity
{
    public class Funcionario : EntidadeBase
    {

        //[Key]
        public int Id { get; set; }

        public virtual ICollection<CargoFuncionario> CargosFuncionario { get; set; }

        public virtual ICollection<Agendamento> ResponsaveisServico { get; set; }
        public virtual ICollection<Agendamento> Atendentes { get; set; }

        public virtual  ICollection<Venda> Vendas { get; set; }

        public virtual ICollection<Agenda> Agendas { get; set; }


        public int IdPessoa { get; set; }

        //[ForeignKey(nameof(IdPessoa))]
        //[InverseProperty("Funcionario")]
        public virtual Pessoa Pessoa { get; set; } 

        public string CPF { get; set; }

        public string RG { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
