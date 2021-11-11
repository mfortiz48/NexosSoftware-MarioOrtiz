using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //vrs.mfortiz 
using System.ComponentModel.DataAnnotations.Schema; // vrs.mfortiz

namespace API_SERVICIOS.Model
{
    public class tb_tecnico
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long tecnico_id { get; set; }
        public string tecnico_dni { get; set; }
        public string tecnico_nombre { get; set; }
        public string tecnico_email { get; set; }
        public string tecnico_direccion { get; set; }
        public string tecnico_estado { get; set; }
    }
}
