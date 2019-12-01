using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HPWebApp.Models
{
    public class Paciente
    {
        public Paciente()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid PropietarioId { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string SenasParticulares { get; set; }
        public string Zona { get; set; }
        public string Chip { get; set; }
        public string NumeroChip { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaDefuncion { get; set; }
        public string MotivoDefuncion { get; set; }
        public string Observacion { get; set; }
        [NotMapped]
        public List<Propietario> Propietarios { get; set; }

    }
}
