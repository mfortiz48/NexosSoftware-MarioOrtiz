using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SERVICIOS.Controllers.ViewModel.Clientes
{
    public class ClienteDTO
    {
        public long id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string tel_fjo { get; set; }
        public string tel_mov { get; set; }
    }
}
