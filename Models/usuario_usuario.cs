//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProbandoLogin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario_usuario
    {
        public int id_usuario_usuario { get; set; }
        public int id_usuario_seguidor { get; set; }
        public int id_usuario_seguido { get; set; }
    
        public virtual usuario usuario { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}
