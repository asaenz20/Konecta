namespace Konecta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Solicitud")]
    public partial class Solicitud
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string CODIGO { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        [StringLength(50)]
        public string RESUMEN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ID_EMPLEADO { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
