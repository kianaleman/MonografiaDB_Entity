//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pro_Mon
    {
        public int IdPro_Mon { get; set; }
        public Nullable<int> Id_Profesor { get; set; }
        public Nullable<int> Id_Monografia { get; set; }
        public string Rol { get; set; }
    
        public virtual Monografia Monografia { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}
