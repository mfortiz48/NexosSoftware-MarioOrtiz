using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mario_Ortiz_API.Controllers.ViewModel.Libro;
using Mario_Ortiz_API.Models;
using Microsoft.AspNetCore.Http;

namespace Mario_Ortiz_API.Controllers
{


    [Route("api/[controller]")]
    public class LibrosController : Controller
    {
        // Variables
        private readonly ILibroService _libroService;

        public LibrosController(ILibroService libroService)
        {
            _libroService = libroService;
        }




        /// <summary>
        /// Crea registros de libros
        /// </summary>
        /// <param name="libroDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] LibroDTO libroDTO)
        {
            try
            {
                var respEditorialViewModel = _libroService.Insert(libroDTO);
                return Ok(respEditorialViewModel);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex);
            }
            catch (Exception ex)
            {
                return BadRequest("Ha ocurrido un error inesperado");
            }

        }






    }
}
