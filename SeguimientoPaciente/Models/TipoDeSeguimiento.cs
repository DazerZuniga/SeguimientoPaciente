//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeguimientoPaciente.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoDeSeguimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoDeSeguimiento()
        {
            this.Historial = new HashSet<Historial>();
            this.ItemsPreventivos = new HashSet<ItemsPreventivos>();
        }
    
        public int idTipo { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historial> Historial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsPreventivos> ItemsPreventivos { get; set; }
    }
}
