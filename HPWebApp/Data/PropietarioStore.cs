using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPWebApp.Models;

namespace HPWebApp.Data
{
    public class PropietarioStore
    {
        public HPContext Context { get; set; }
        public PropietarioStore(HPContext context)
        {
            Context = context;
        }

        internal void DeletePropietario(Guid id)
        {
            var propietario = Context.Propietarios.FirstOrDefault(x => x.Id == id);
            this.Context.Propietarios.Remove(propietario);
            Context.SaveChanges();
        }

        internal void AddPropietario(Propietario propietario)
        {
            Context.Propietarios.Add(propietario);
            Context.SaveChanges();
        }

        internal Propietario GetPropietarioById(Guid id)
        {
            return Context.Propietarios.FirstOrDefault(x => x.Id == id);
        }

        internal void EditPropietario(Propietario propietario)
        {
            Propietario CurrentPropietario = GetPropietarioById(propietario.Id);
            CurrentPropietario.PrimerNombre = propietario.PrimerNombre;
            CurrentPropietario.PrimerApellido = propietario.PrimerApellido;
            CurrentPropietario.TipoIdentificacion = propietario.TipoIdentificacion;
            CurrentPropietario.Identificacion = propietario.Identificacion;
            CurrentPropietario.Ciudad = propietario.Ciudad;

            Context.Propietarios.Update(CurrentPropietario);
            Context.SaveChanges();
        }

        internal List<Propietario> GetPropietarios()
        {
            return Context.Propietarios.ToList();
        }
    }
}
