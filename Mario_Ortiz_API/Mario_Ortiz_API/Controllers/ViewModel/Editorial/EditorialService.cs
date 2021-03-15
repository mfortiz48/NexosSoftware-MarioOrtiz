using Mario_Ortiz_API.Controllers.ViewModel.Editorial;
using Mario_Ortiz_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mario_Ortiz_API.Controllers.ViewModel.Editorial
{
    public class EditorialService : IEditorialService
    {
        private readonly _DbContex _context;

        public EditorialService(_DbContex context)
        {
            _context = context;
        }

        public EditorialDTO Insert(EditorialDTO editorialViewModel)
        {
            if (string.IsNullOrEmpty(editorialViewModel.Nombre) || string.IsNullOrWhiteSpace(editorialViewModel.Nombre)
                || string.IsNullOrEmpty(editorialViewModel.Direccion) || string.IsNullOrWhiteSpace(editorialViewModel.Direccion)
                || string.IsNullOrEmpty(editorialViewModel.Email) || string.IsNullOrWhiteSpace(editorialViewModel.Email))
            {
                throw new ApplicationException("Datos incompletos");
            }


            if (_context.Tb_editoriales.Any(e => e.Editorial_nombre.ToUpper() == editorialViewModel.Nombre.ToUpper()))
            {
                string mensaje = string.Format("Ya existe la editorial {0}", editorialViewModel.Nombre);
                throw new ApplicationException(mensaje);
            }

            Tb_Editorial editorial = Map(editorialViewModel);
            _context.Add(editorial);
            if (_context.SaveChanges() >= 1)
                return Map(editorial);
            else
                return null;

        }



        public EditorialDTO Select(long id)
        {
            var entidad = _context.Tb_editoriales.FirstOrDefault(e => e.Editorial_id == id);
            return Map(entidad);
        }

        private Tb_Editorial Map(EditorialDTO editorialViewModel)
        {
            return new Tb_Editorial()
            {
                Editorial_id = editorialViewModel.Id,
                Editorial_nombre = editorialViewModel.Nombre,
                Editorial_Direccion = editorialViewModel.Direccion,
                Editorial_Telefono = editorialViewModel.Telefono,
                Editorial_email = editorialViewModel.Email,
                Editorial_librosRegistrados = editorialViewModel.LibrosRegistrados
            };
        }

        private EditorialDTO Map(Tb_Editorial editorial)
        {
            return editorial == null ? null : new EditorialDTO()
            {
                Id = editorial.Editorial_id,
                Nombre = editorial.Editorial_nombre,
                Direccion = editorial.Editorial_Direccion,
                Telefono = editorial.Editorial_Telefono,
                Email = editorial.Editorial_email,
                LibrosRegistrados = editorial.Editorial_librosRegistrados
            };
        }

    }
}
