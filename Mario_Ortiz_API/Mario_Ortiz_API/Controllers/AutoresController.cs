using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mario_Ortiz_API.Models;
using Mario_Ortiz_API.Controllers.ViewModel.Autor;

namespace Mario_Ortiz_API.Controllers
{
    [Route("api/[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorService _autorservice;

        public AutoresController(IAutorService autorService)
        {
            _autorservice = autorService;
        }


        /// <summary>
        /// obtiene informacion de autores
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var respAutorDTO = _autorservice.Select();
                return Ok(respAutorDTO);
            }
            catch (Exception ex)
            {
                return BadRequest("Ha ocurrido un error inesperado");
            }
        }



        /// <summary>
        /// Crear Registros de Autores
        /// </summary>
        /// <param name="autorDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] AutorDTO autorDTO)
        {
            try
            {
                var respAutorDTO = _autorservice.Insert(autorDTO);
                return Ok(respAutorDTO);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex);
            }
            catch (Exception ex)
            {
                //Logguear ex
                return BadRequest("Ha ocurrido un error inesperado");
            }

        }





    }
}
