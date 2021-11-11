using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mario_Ortiz_API.Controllers.ViewModel.Autor
{
    public  interface IAutorService
    {
         List<AutorDTO> Select();
        AutorDTO Insert(AutorDTO autorlViewModel);

    }
}
