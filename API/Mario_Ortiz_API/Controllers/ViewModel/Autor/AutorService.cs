using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mario_Ortiz_API.Controllers.ViewModel;
using Mario_Ortiz_API.Models;

namespace Mario_Ortiz_API.Controllers.ViewModel.Autor
{ 
    public class AutorService : IAutorService
    {
        private readonly _DbContex _context;

        public AutorService(_DbContex context)
        {
            _context = context;
        }

        /// <summary>
        /// Inserta Autores
        /// </summary>
        /// <param name="autorlViewModel"></param>
        /// <returns></returns>
        public AutorDTO Insert(AutorDTO autorlViewModel)
        {
            if (String.IsNullOrEmpty(autorlViewModel.Nombre) || String.IsNullOrWhiteSpace(autorlViewModel.Nombre) 
                || String.IsNullOrEmpty(autorlViewModel.Ciudad)|| String.IsNullOrWhiteSpace(autorlViewModel.Ciudad)
                ||  String.IsNullOrEmpty(autorlViewModel.FechaNacimiento.ToString()) || String.IsNullOrWhiteSpace(autorlViewModel.FechaNacimiento.ToString())
                || String.IsNullOrEmpty(autorlViewModel.Email) || String.IsNullOrWhiteSpace(autorlViewModel.Email))
            {
                throw new ApplicationException("Datos Incompletos");
            }

            Tb_Autor autor = Map(autorlViewModel);
            _context.Add(autor);
            if (_context.SaveChanges () >= 1)
            {
                return Map(autor);
            }
            else
            {
                return null;
            } 
        }




        public List<AutorDTO> Select()
        {
            List<Tb_Autor> tb_autorlist = new List<Tb_Autor>();


            tb_autorlist = _context.Tb_autores.Select(s => s).ToList();


            var  respuesta = Map(tb_autorlist);
            return respuesta;
        }




        /// <summary>
        /// Convierte un modelo AutorDTO A tb_autor
        /// </summary>
        /// <param name="autorDTO"></param>
        /// <returns></returns>
          private  Tb_Autor Map (AutorDTO autorDTO) 
        {
            return new Tb_Autor()
            {
                autor_id = autorDTO.Id,
                autor_ciudad = autorDTO.Ciudad,
                autor_Email = autorDTO.Email,
                autor_fechaNacimiento = autorDTO.FechaNacimiento,
                autor_nombre = autorDTO.Nombre
            };     
        }



        /// <summary>
        /// Convierte un modelo Tb_autor a autorDTO
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        private AutorDTO Map(Tb_Autor autor) 
        {
            return autor == null ? null : new AutorDTO()
            {
                Id = autor.autor_id,
                Ciudad = autor.autor_ciudad,
                Email= autor.autor_Email,
                FechaNacimiento = autor.autor_fechaNacimiento,
                Nombre = autor.autor_nombre
            }; 
        }


        private List<AutorDTO> Map(List<Tb_Autor> autor)
        {
            List<AutorDTO> AutorDTOLista = new List<AutorDTO>();


            foreach (var item in autor)
            {
                AutorDTO autorDTO = new AutorDTO();

                autorDTO.Id = item.autor_id;
                autorDTO.Nombre = item.autor_nombre;
                autorDTO.Ciudad = item.autor_ciudad;
                autorDTO.Email = item.autor_Email;
                autorDTO.FechaNacimiento = item.autor_fechaNacimiento;

                AutorDTOLista.Add(autorDTO);
            }

            return AutorDTOLista;


        }


        private List<Tb_Autor> Map(List<AutorDTO> autordto)
        {
            List<Tb_Autor> AutorLista = new List<Tb_Autor>();


            foreach (var item in autordto)
            {
                Tb_Autor autor = new Tb_Autor();

                autor.autor_id = item.Id;
                autor.autor_nombre = item.Nombre;
                autor.autor_ciudad = item.Ciudad;
                autor.autor_Email = item.Email;
                autor.autor_fechaNacimiento = item.FechaNacimiento;

                AutorLista.Add(autor);
            }

            return AutorLista;


        }







    }
}
