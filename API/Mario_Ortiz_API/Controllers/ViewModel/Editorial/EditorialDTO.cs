using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mario_Ortiz_API.Controllers.ViewModel.Editorial
{
    public class EditorialDTO
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int LibrosRegistrados { get; set; }
    }
}
