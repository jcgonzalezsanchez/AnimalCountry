using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPWebApp.Models
{
    public class PropietarioPaciente
    {
        public Guid Id { get; set; }
        public Guid PropietarioId { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public Guid PacienteId { get; set; }
        public string Nombre { get; set; }
        public Propietario Propietario { get; set; }
        public Paciente Paciente { get; set; }
    }
}
