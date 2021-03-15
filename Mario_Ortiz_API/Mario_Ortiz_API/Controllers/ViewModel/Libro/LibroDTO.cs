using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mario_Ortiz_API.Controllers.ViewModel.Libro
{
    public class LibroDTO
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public int Año { get; set; }
        public string Genero { get; set; }
        public int NumeroPaginas { get; set; }
        public long Libro_Autor { get; set; }
        public long Libro_Editorial { get; set; }
    }
}
