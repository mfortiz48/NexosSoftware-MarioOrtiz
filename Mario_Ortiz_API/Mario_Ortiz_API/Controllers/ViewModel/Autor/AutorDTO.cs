using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mario_Ortiz_API.Controllers.ViewModel.Autor
{
    public class AutorDTO
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
    }
}
