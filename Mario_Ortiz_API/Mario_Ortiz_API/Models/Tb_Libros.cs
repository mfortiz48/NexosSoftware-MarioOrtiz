using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // vrs.mortiz
using System.ComponentModel.DataAnnotations.Schema; //vrs.mortiz

namespace Mario_Ortiz_API.Models
{
    public class Tb_Libro
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] 

        public  long libro_Id { get; set; }  
        public  string libro_titulo { get; set; }  
        public  int libro_año { get; set; }  
        public  string libro_genero { get; set; } 
        public int  libro_NumeroPaginas { get; set; }

        // foreing key
        public long  Libro_Autor { get; set; }
        public long  Libro_Editorial { get; set; }

        [ForeignKey("Libro_Autor")]
        public virtual Tb_Autor Autores { get; set; }

        [ForeignKey("Libro_Editorial")]
        public virtual Tb_Editorial Editoriales { get; set; }






    }
}
