using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPWebApp.Data;
using HPWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HPWebApp.Pages.Pacientes
{
    public class AddModel : PageModel
    {
        public PacienteStore PacienteStore { get; set; }
        public AddModel(PacienteStore pacienteStore)
        {
            PacienteStore = pacienteStore;
        }

        [BindProperty]
        public Paciente Paciente { get; set; }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Add

            Paciente.PropietarioId = PropietarioId;
            PacienteStore.AddPaciente(Paciente);
            return RedirectToPage("./Index");

        }

        [BindProperty]
        public Guid PropietarioId { get; set; }
        public void OnGet(Guid propietarioid)
        {
            PropietarioId = propietarioid;
        }
    }
}