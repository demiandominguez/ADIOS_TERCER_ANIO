//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        public int id { get; set; }
        public string razonSocial { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public Nullable<int> direccion_numero { get; set; }
        public string dpto { get; set; }
        public string codigoPostal { get; set; }
        public string cuit { get; set; }
        public string contacto { get; set; }
        public Nullable<int> idRubro { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public Nullable<int> idLocalidad { get; set; }
        public Nullable<int> calificacionPromedio { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
    
        public virtual Localidad Localidad { get; set; }
        public virtual Rubro Rubro { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}