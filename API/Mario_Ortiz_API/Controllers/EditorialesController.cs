using Mario_Ortiz_API.Controllers.ViewModel.Editorial;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mario_Ortiz_API.Controllers
{
    [Route("api/[controller]")]
    public class EditorialesController : ControllerBase
    {
        private readonly IEditorialService _editorialService;

        public EditorialesController(IEditorialService editorialService)
        {
            _editorialService = editorialService;
        }



        /// <summary>
        /// Obtiene la informacion de una editorial por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            try
            {
                var respEditorialViewModel = _editorialService.Select(id);
                return Ok(respEditorialViewModel);
            }
            catch (Exception ex)
            {
                return BadRequest("Ha ocurrido un error inesperado");
            }
        }




        /// <summary>
        /// Crea un registro de Editoriales
        /// </summary>
        /// <param name="editorialDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] EditorialDTO editorialDTO)
        {
            try
            {
                var respEditorialViewModel = _editorialService.Insert(editorialDTO);
                return Ok(respEditorialViewModel);
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
