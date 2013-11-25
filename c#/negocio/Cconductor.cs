using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace negocio
{
    public class Cconductor
    {
        transitoEntities bd = new transitoEntities();
        public void guardar(string nom, string ap, string dir, int i, int tel)
        {
            conductor c = new conductor();
            c.nombre = nom;
            c.apellido = ap;
            c.direccion = dir;
            c.ci = i;
            c.telefono = tel;
            bd.conductor.AddObject(c);
            bd.SaveChanges();
        }
    }
}
