﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAS.Domain.Entity
{

    public class FuncaoUsuario : EntidadeBaseUserRole
    {

       
       // [Column("FNUS_ID_USUARIO")]
        public int UserId { get; set; }

       // [Column("FNUS_ID_FUNCAO")]
        public int RoleId { get; set; }

        public virtual Funcao Role { get; set; }

        public virtual Usuario User { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime? DataFim { get; set; }

    }
}