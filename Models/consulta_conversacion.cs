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
    
    public partial class consulta_conversacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public consulta_conversacion()
        {
            this.consulta_mensaje = new HashSet<consulta_mensaje>();
        }
    
        public int id_consulta_conversacion { get; set; }
        public int id_usuario_remitente { get; set; }
        public int id_usuario_destinatario { get; set; }
        public bool cerrada { get; set; }
    
        public virtual usuario usuario { get; set; }
        public virtual usuario usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consulta_mensaje> consulta_mensaje { get; set; }
    }
}
