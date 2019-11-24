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

        internal List<Propietario> GetPropietarios()
        {
            return Context.Propietario.ToList();
        }
    }
}
