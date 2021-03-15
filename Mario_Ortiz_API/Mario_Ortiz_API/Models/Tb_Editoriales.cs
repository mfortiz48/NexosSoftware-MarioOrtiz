using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // vrs.mfortiz
using System.ComponentModel.DataAnnotations.Schema; // vrs.mfortiz

namespace Mario_Ortiz_API.Models
{
    public class Tb_Editorial
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long  Editorial_id { get; set; }
        public string  Editorial_nombre { get; set; }
        public string  Editorial_Direccion { get; set; }
        public string  Editorial_Telefono { get; set; }
        public string  Editorial_email { get; set; }
        public int  Editorial_librosRegistrados { get; set; }
    }
}
