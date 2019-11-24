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
    public class AddModel : PageModel
    {
        public PropietarioStore PropietarioStore { get; set; }
        public AddModel(PropietarioStore propietarioStore)
        {
            PropietarioStore = propietarioStore;
        }

        [BindProperty]
        public Propietario Propietario { get; set; }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Add
            PropietarioStore.AddPropietario(Propietario);
            return RedirectToPage("./Index");
        }

        

            



        public void OnGet()
        {

        }
    }
}