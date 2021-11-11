using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mario_Ortiz_API.Controllers.ViewModel.Editorial
{
    public interface IEditorialService
    {
        EditorialDTO Select(long id);
        EditorialDTO Insert(EditorialDTO editorialViewModel);
    }
}
