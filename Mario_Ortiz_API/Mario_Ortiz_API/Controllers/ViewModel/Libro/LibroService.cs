using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mario_Ortiz_API.Controllers.ViewModel.Libro;
using Mario_Ortiz_API.Models;

namespace Mario_Ortiz_API.Controllers.ViewModel.Libro
{
    public class LibroService : ILibroService
    {




        private readonly _DbContex _context;

        public LibroService(_DbContex context)
        {
            _context = context;
        }





        public LibroDTO Insert(LibroDTO libroDTO)
        {

            if (string.IsNullOrEmpty(libroDTO.Titulo) || string.IsNullOrWhiteSpace(libroDTO.Titulo)
                || string.IsNullOrEmpty(libroDTO.Libro_Autor.ToString()) || string.IsNullOrWhiteSpace(libroDTO.Libro_Autor.ToString())
                || string.IsNullOrEmpty(libroDTO.Libro_Editorial.ToString()) || string.IsNullOrWhiteSpace(libroDTO.Libro_Editorial.ToString())
                || string.IsNullOrEmpty(libroDTO.Genero) || string.IsNullOrWhiteSpace(libroDTO.Genero)
                || string.IsNullOrEmpty(libroDTO.Año.ToString()) || string.IsNullOrWhiteSpace(libroDTO.Año.ToString()))
            {
                throw new ApplicationException("Datos incompletos");
            }


         
            Tb_Libro libro = Map(libroDTO);
            _context.Add(libro);
            if (_context.SaveChanges() >= 1)
                return Map(libro);
            else
                return null;

        }





        private Tb_Libro Map(LibroDTO libroDTO)
        {
            return new Tb_Libro()
            {
                libro_Id = libroDTO.Id,
                libro_titulo = libroDTO.Titulo,
                libro_genero = libroDTO.Genero,
                libro_año = libroDTO.Año,
                libro_NumeroPaginas = libroDTO.NumeroPaginas,
                Libro_Autor = libroDTO.Libro_Autor,
                Libro_Editorial = libroDTO.Libro_Editorial
            };
        }

        private LibroDTO Map(Tb_Libro libro)
        {
            return new LibroDTO()
            {
                Id = libro.libro_Id,
                Titulo = libro.libro_titulo,
                Genero = libro.libro_genero,
                Año = libro.libro_año,
                NumeroPaginas = libro.libro_NumeroPaginas,
                Libro_Autor = libro.Libro_Autor,
                Libro_Editorial = libro.Libro_Editorial
            };
        }

    }
}
