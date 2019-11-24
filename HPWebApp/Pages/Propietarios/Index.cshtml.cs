using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPWebApp.Data;
using HPWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HPWebApp.Pages.Propietarios
{
    public class IndexModel : PageModel
    {
        public PropietarioStore PropietarioStore { get; set; }
        public List<Propietario> Propietarios { get; set; }

        public IndexModel(PropietarioStore propietarioStore)
        {
            PropietarioStore = propietarioStore;
            Propietarios = PropietarioStore.GetPropietarios();
        }

        public IActionResult OnPostDelete(Guid id)
        {
            PropietarioStore.DeletePropietario(id);
            return RedirectToPage();
        }


        public void OnGet()
        {
        }
    }
}
