using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //vrs.mfortiz 
using System.ComponentModel.DataAnnotations.Schema; // vrs.mfortiz

namespace API_SERVICIOS.Model
{
    public class tb_direccionCliente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long direccionCliente_id { get; set; }
        public long direccionCliente_Cliente_Id { get; set; }
        [ForeignKey("direccionCliente_Cliente_Id")]
        public virtual tb_clientes Clientes { get; set; }
        public string direccionCliente_Descripcion{ get; set; }
        public string direccionCliente_coordenada_x { get; set; }
        public string direccionCliente_coordenada_y { get; set; }
        public string direccionCliente_estado { get; set; }
       
    }
}
