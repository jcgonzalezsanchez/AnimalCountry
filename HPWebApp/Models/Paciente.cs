﻿using System;
using System.Collections.Generic;
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
        public List<PropietarioPaciente> PropietarioPacientes { get; set; }
    }
}
