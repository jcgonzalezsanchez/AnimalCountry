using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HPWebApp.Data
{
    public class PacienteStore
    {
        public HPContext Context { get; set; }
        public PacienteStore(HPContext context)
        {
            Context = context;
        }

        internal List<Paciente> GetPacientes()
        {
            return Context.Pacientes.Include(x => x.Propietarios).ToList();
        }

        internal void DeletePaciente(Guid id)
        {
            var propietario = Context.Pacientes.FirstOrDefault(x => x.Id == id);
            Context.Pacientes.Remove(propietario);
            Context.SaveChanges();
        }

        internal Paciente GetPacienteById(Guid id)
        {
            return Context.Pacientes
                .Include(x => x.Propietarios)
                .FirstOrDefault(x => x.Id == id);
        }

        internal void AddPaciente(Paciente paciente)
        {
            Context.Pacientes.Add(paciente);
            Context.SaveChanges();
        }

        internal void EditPaciente(Paciente paciente)
        {
            Paciente CurrentPaciente = GetPacienteById(paciente.Id);
            CurrentPaciente.Nombre = paciente.Nombre;
            CurrentPaciente.Color = paciente.Color;
            CurrentPaciente.SenasParticulares = paciente.SenasParticulares;
            CurrentPaciente.Zona = paciente.Zona;
            CurrentPaciente.Chip = paciente.Chip;
            CurrentPaciente.NumeroChip = paciente.NumeroChip;
            CurrentPaciente.FechaNacimiento = paciente.FechaNacimiento;
            CurrentPaciente.FechaDefuncion = paciente.FechaDefuncion;
            CurrentPaciente.MotivoDefuncion = paciente.MotivoDefuncion;
            CurrentPaciente.Observacion = paciente.Observacion;


            Context.Pacientes.Update(CurrentPaciente);
            Context.SaveChanges();
        }
    }
}
