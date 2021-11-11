using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //vrs.mfortiz 
using System.ComponentModel.DataAnnotations.Schema; // vrs.mfortiz

namespace API_SERVICIOS.Model
{
    public class tb_servicioDetalle
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long servicioDetalle_id { get; set; }
        public long servicioDetalle_Servicio_id { get; set; }
        [ForeignKey("servicioDetalle_Servicio_id")]
        public virtual tb_servicio Servicio { get; set; }
        public string equipo { get; set; }
        public long servicioDetalle_sevicio_tpoId { get; set; }
        [ForeignKey("servicio_sevicio_tpoId")]
        public virtual tb_servicio_tpo Servicio_tipo { get; set; }

        public string ServicioDetalle_LugarCompra { get; set; }
        public string ServicioDetalle_fechaCompra { get; set; }
    }
}
