﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System.Collections.Generic;

namespace SGAS.Domain.Entity
{
    public class Cidade : EntidadeBase
    {
       
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdMicroRegiao { get; set; }
        public int IdEstado { get; set; }
        //public Estado? Estado { get; set; }      
        public  MicroRegiao MicrorRegiao { get; set; }       
        public  ICollection<Cep> Cep { get; set; }      
        public  ICollection<Endereco> Endereco { get; set; }
    }
}