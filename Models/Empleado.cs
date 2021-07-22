namespace Konecta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            Solicitud = new HashSet<Solicitud>();
        }

        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FECHA_INGRESO { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SALARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitud> Solicitud { get; set; }
    }
}
