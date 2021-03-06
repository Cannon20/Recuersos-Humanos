//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Recuersos_Humanos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            this.Licencias = new HashSet<Licencias>();
            this.Nomina = new HashSet<Nomina>();
            this.Permiso = new HashSet<Permiso>();
            this.Salida = new HashSet<Salida>();
            this.Vacaciones = new HashSet<Vacaciones>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Codigo_Empleado { get; set; }
        public Nullable<int> Departamento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<int> Cargo { get; set; }
        public Nullable<decimal> Salario { get; set; }
        public Nullable<System.DateTime> Fecha_DE_Ingreso { get; set; }
        public string Telefono { get; set; }
        public string Estatus { get; set; }
    
        public virtual cargo cargo1 { get; set; }
        public virtual Departamento Departamento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licencias> Licencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nomina> Nomina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permiso> Permiso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida> Salida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacaciones> Vacaciones { get; set; }
    }
}
