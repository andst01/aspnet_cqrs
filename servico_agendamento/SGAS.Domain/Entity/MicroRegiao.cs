﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System.Collections.Generic;

namespace SGAS.Domain.Entity
{
    public partial class MicroRegiao : EntidadeBase
    {
       
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? IdMesoRegiao { get; set; }
        public virtual MesoRegiao MesorRegiao { get; set; }      
        public virtual ICollection<Cidade> Cidade { get; set; }
    }
}