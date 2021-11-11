using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //vrs.mfortiz 
using System.ComponentModel.DataAnnotations.Schema; // vrs.mfortiz

namespace API_SERVICIOS.Model
{
    public class tb_servicio
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long servicio_id { get; set; }
        public long servicio_consecutivo { get; set; }
        public long servicio_cliente_id { get; set; }
        [ForeignKey("servicio_cliente_id")]
        public virtual tb_clientes Clientes { get; set; }
        public DateTime servicio_fechaApertura { get; set; }
        public DateTime servicio_Fecha_gestion { get; set; }
        public long Servicio_Tecnico_Id { get; set; }
        [ForeignKey("Servicio_Tecnico_Id")]
        public virtual tb_tecnico Tecnicos { get; set; }
        public string Servicio_Observacion { get; set; }
    }
}
