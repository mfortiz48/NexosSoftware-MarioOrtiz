using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //vrs.mfortiz 
using System.ComponentModel.DataAnnotations.Schema; // vrs.mfortiz

namespace API_SERVICIOS.Model
{
    public class tb_clientes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long cliente_id { get; set; }

        public string cliente_email { get; set; }
        public string cliente_dni { get; set; }
        public string cliente_nombre { get; set; }
        public  string  cliente_tpo { get; set; }       
        public string cliente_direccion { get; set; }

        public string cliente_tel_fjo { get; set; }
        public string cliente_tel_mov { get; set; }
    }
}
