﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPWebApp.Models
{
    public class PropietarioPaciente
    {
        public Guid Id { get; set; }
        public Guid PropietarioId { get; set; }
        public Guid PacienteId { get; set; }
        public Propietario Propietario { get; set; }
        public Paciente Paciente { get; set; }
    }
}
