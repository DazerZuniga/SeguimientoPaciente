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
    
    public partial class FarmacoReceta
    {
        public int idFarmacoReceta { get; set; }
        public Nullable<int> idFarmaco { get; set; }
        public Nullable<int> idReceta { get; set; }
    
        public virtual Farmacos Farmacos { get; set; }
    }
}
