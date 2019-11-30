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
    public class IndexModel : PageModel
    {
        public PacienteStore PacienteStore { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public List<Propietario> Propietarios { get; set; }

        public IndexModel(PacienteStore pacienteStore)
        {
            PacienteStore = pacienteStore;
            Pacientes = PacienteStore.GetPacientes();
        }

        public IActionResult OnPostDelete(Guid id)
        {
            PacienteStore.DeletePaciente(id);
            return RedirectToPage();
        }

        public void OnGet()
        {
        }
    }
}
