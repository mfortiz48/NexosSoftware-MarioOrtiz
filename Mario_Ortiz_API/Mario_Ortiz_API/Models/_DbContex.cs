using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;




namespace Mario_Ortiz_API.Models
{
    public class _DbContex:DbContext
    {


       

        public _DbContex(DbContextOptions<_DbContex> options): base(options)
        {
        }

      


        // Modelos 

        public DbSet<Tb_Libro> Tb_libros { get; set; }
        public DbSet<Tb_Autor> Tb_autores { get; set; }
        public DbSet<Tb_Editorial> Tb_editoriales { get; set; }




    }
}
