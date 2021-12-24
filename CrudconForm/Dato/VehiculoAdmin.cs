using CrudconForm.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudconForm.Dato
{
    public class VehiculoAdmin
    {
        public List<vehiculo> Consultar()
        {
            using(PruebaDBEntities2 contexto = new PruebaDBEntities2())
            {
                return contexto.vehiculo.AsNoTracking().ToList();
            }
        }

        public void Guardar(vehiculo modelo)
        {
            using (PruebaDBEntities2 contexto = new PruebaDBEntities2())
            {
                contexto.vehiculo.Add(modelo);
                contexto.SaveChanges();
            }
        }
    }
}
