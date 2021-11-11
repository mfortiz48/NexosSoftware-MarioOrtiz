using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_SERVICIOS.Model; // vrs.1000 Mfortiz

namespace API_SERVICIOS.Controllers.ViewModel.Clientes
{
    public class ClienteService:IClienteService
    {
        private readonly _DbContext _context;

        public ClienteService(_DbContext context)
        {
            _context = context;
        }









    }
}
