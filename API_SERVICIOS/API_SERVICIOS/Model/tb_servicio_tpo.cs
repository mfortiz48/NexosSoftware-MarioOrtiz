using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //vrs.mfortiz 
using System.ComponentModel.DataAnnotations.Schema; // vrs.mfortiz

namespace API_SERVICIOS.Model
{
    public class tb_servicio_tpo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long servicio_tpo_id { get; set; }
        public string servicio_tpo_cod { get; set; }
        public string servicio_tpo_descripcion { get; set; }
        public string servicio_tpo_estado { get; set; }
    }
}
