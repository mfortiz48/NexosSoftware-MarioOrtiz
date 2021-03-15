using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //vrs.mfortiz 
using System.ComponentModel.DataAnnotations.Schema; // vrs.mfortiz

namespace Mario_Ortiz_API.Models
{
    public class Tb_Autor
    {

   [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long autor_id { get; set; }
    public string autor_nombre { get; set; }
    public DateTime autor_fechaNacimiento { get; set; }
    public string autor_ciudad { get; set; }
    public string autor_Email { get; set; }




    }
}
