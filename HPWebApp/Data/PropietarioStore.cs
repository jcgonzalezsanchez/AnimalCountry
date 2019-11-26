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
            var propietario = Context.Propietario.FirstOrDefault(x => x.Id == id);
            this.Context.Propietario.Remove(propietario);
            Context.SaveChanges();
        }

        internal void AddPropietario(Propietario propietario)
        {
            Context.Propietario.Add(propietario);
            Context.SaveChanges();
        }

        internal Propietario GetPropietarioById(Guid id)
        {
            return Context.Propietario.FirstOrDefault(x => x.Id == id);
        }

        internal void EditPropietario(Propietario propietario)
        {
            Propietario CurrentPropietario = GetPropietarioById(propietario.Id);
            CurrentPropietario.PrimerNombre = propietario.PrimerNombre;
            CurrentPropietario.PrimerApellido = propietario.PrimerApellido;
            CurrentPropietario.TipoIdentificacion = propietario.TipoIdentificacion;
            CurrentPropietario.Identificacion = propietario.Identificacion;
            CurrentPropietario.Ciudad = propietario.Ciudad;

            Context.Propietario.Update(CurrentPropietario);
            Context.SaveChanges();
        }

        internal List<Propietario> GetPropietarios()
        {
            return Context.Propietario.ToList();
        }
    }
}
