using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mario_Ortiz_API.Controllers.ViewModel.Libro;

namespace Mario_Ortiz_API.Controllers.ViewModel.Libro
{
     public interface ILibroService
    {
        LibroDTO Insert(LibroDTO libroDTO);

    }
}
