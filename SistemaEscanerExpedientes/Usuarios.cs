//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaEscanerExpedientes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contra { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public System.DateTime FechaModificado { get; set; }
        public int IdEstado { get; set; }
        public int IdTipoUsuario { get; set; }
    
        public virtual EstadoUsuario EstadoUsuario { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
